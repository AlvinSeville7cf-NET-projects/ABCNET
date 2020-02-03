@echo off& :: by Alex Dragokas -02.01.2013-
::Помощник компиляции исходников C#
Setlocal EnableDelayedExpansion EnableExtensions

::Задайте путь к файлу настроек скрипта
set FWCompilerPath=%temp%\FWCompile.cfg
::Задайте здесь полный путь к компилятору, либо он будет найден и сохранен автоматически в файл FWCompile.cfg
::set FWExec=c:\Windows\Microsoft.NET\Framework\v3.5\csc.exe
::Путь к временным файлам протокола ошибок
set log866=%temp%\compile_err866.log
set log1251=%temp%\compile_err.log

Echo Помощник компиляции исходных файлов C# (.cs)
Echo.
if "%1"=="" (
  Echo Перетяните исходный файл .cs на этот скрипт ^(Drag ^& Drop^),
  Echo или задайте его как аргумент, например "%~nx0" "c:\temp\source.cs"
  Echo.& pause& Goto :eof
)

::Если путь указан в шапке
if Defined FWExec goto :begin
::Читаю путь к компилятору из файла настроек
if exist "%FWCompilerPath%" for /f "UseBackQ delims=" %%A in ("%FWCompilerPath%") do set FWExec=%%A& goto :begin

Echo Выберите версию FrameWork, с помощью которой по-умолчанию будет компилироваться исходник
Echo.
for /f "delims=" %%A in ('dir /b /s /a:-d "%windir%\Microsoft.NET\csc.exe"') do (
  Set /A n+=1
  Set FW!n!=%%A
  for /f "tokens=4,5 delims=\" %%r in ("%%A") do (
    echo %%r|find "64">nul
    if !errorlevel!==0 (set arch=x64) else (set arch=x32)
    echo !n!. !arch! %%s
  )
)
if not Defined n (Echo На компьютере не обнаружен установленный FrameWork& Echo.& pause& goto :eof)
Echo.
:FWenter
Set /p FWver="Ожидаю ввода: "
if "%FWver%"=="" Goto :FWenter
if %FWver% LSS 0 Goto :FWenter
if %FWver% GTR %n% Goto :FWenter
set FWExec=!FW%FWver%!
Echo %FWExec%> "%FWCompilerPath%"

::Дополнительные параметры
::/unsafe - компиляция блоков с прямым доступом к памяти
::/reference:"%Ref%\addon.dll" - подключить дополнительный модуль
::/target:library - скомпилировать как библиотеку классов; winexe - исполнительный файл Windows
::/res:"file.mp3" - внедрить в ресурсы внешний файл
::/debug - отображать отладочную информацию
::/warn:0 - уровень предупреждений
::/nologo - не отображать информацию об авторских правах
:begin
"%FWExec%" /target:exe /nologo /out:"%~dpn1.exe" "%~dpnx1" 1>"%log866%" 2>&1
if %errorlevel% neq 0 (
  Call :Recode
  Echo Во время компиляции возникла ошибка
  Echo.
  Type "%log866%"
  Echo.
  (set /p key=Нажмите Y, чтобы сохранить протокол ошибок в файл: )
  if /i "!key!"=="Y" (move /y "%log1251%" "%~dp1"& del /q "%log866%") else (del /q "%log866%"& del /q "%log1251%")  
) else (del /q "%log866%")
Exit /B

:Recode
::Файл с кодировкой WIN-866
set FileIn=%log866%
::Результат, куда записывать OEM-1251
set FileOut=%log1251%
 ::chcp 1251> nul
for /f "delims=" %%a in (%FileIn%) do (
  if not defined cpReady (
    chcp 1251> nul
    set CpReady=True
  )
  call :convert "%%a"
)
chcp 866> nul
exit /B

:convert
echo %~1>>"%FileOut%"
Exit /B
