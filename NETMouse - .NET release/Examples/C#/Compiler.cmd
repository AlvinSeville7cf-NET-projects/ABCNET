@echo off& :: by Alex Dragokas -02.01.2013-
::����魨� �������樨 ��室����� C#
Setlocal EnableDelayedExpansion EnableExtensions

::������ ���� � 䠩�� ����஥� �ਯ�
set FWCompilerPath=%temp%\FWCompile.cfg
::������ ����� ����� ���� � ����������, ���� �� �㤥� ������ � ��࠭�� ��⮬���᪨ � 䠩� FWCompile.cfg
::set FWExec=c:\Windows\Microsoft.NET\Framework\v3.5\csc.exe
::���� � �६���� 䠩��� ��⮪��� �訡��
set log866=%temp%\compile_err866.log
set log1251=%temp%\compile_err.log

Echo ����魨� �������樨 ��室��� 䠩��� C# (.cs)
Echo.
if "%1"=="" (
  Echo ����ﭨ� ��室�� 䠩� .cs �� ��� �ਯ� ^(Drag ^& Drop^),
  Echo ��� ������ ��� ��� ��㬥��, ���ਬ�� "%~nx0" "c:\temp\source.cs"
  Echo.& pause& Goto :eof
)

::�᫨ ���� 㪠��� � 蠯��
if Defined FWExec goto :begin
::���� ���� � ���������� �� 䠩�� ����஥�
if exist "%FWCompilerPath%" for /f "UseBackQ delims=" %%A in ("%FWCompilerPath%") do set FWExec=%%A& goto :begin

Echo �롥�� ����� FrameWork, � ������� ���ன ��-㬮�砭�� �㤥� �������஢����� ��室���
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
if not Defined n (Echo �� �������� �� �����㦥� ��⠭������� FrameWork& Echo.& pause& goto :eof)
Echo.
:FWenter
Set /p FWver="������ �����: "
if "%FWver%"=="" Goto :FWenter
if %FWver% LSS 0 Goto :FWenter
if %FWver% GTR %n% Goto :FWenter
set FWExec=!FW%FWver%!
Echo %FWExec%> "%FWCompilerPath%"

::�������⥫�� ��ࠬ����
::/unsafe - ��������� ������ � ���� ����㯮� � �����
::/reference:"%Ref%\addon.dll" - ��������� �������⥫�� �����
::/target:library - ᪮�����஢��� ��� ������⥪� ����ᮢ; winexe - �ᯮ���⥫�� 䠩� Windows
::/res:"file.mp3" - ������� � ������ ���譨� 䠩�
::/debug - �⮡ࠦ��� �⫠����� ���ଠ��
::/warn:0 - �஢��� �।�०�����
::/nologo - �� �⮡ࠦ��� ���ଠ�� �� ����᪨� �ࠢ��
:begin
"%FWExec%" /target:exe /nologo /out:"%~dpn1.exe" "%~dpnx1" 1>"%log866%" 2>&1
if %errorlevel% neq 0 (
  Call :Recode
  Echo �� �६� �������樨 �������� �訡��
  Echo.
  Type "%log866%"
  Echo.
  (set /p key=������ Y, �⮡� ��࠭��� ��⮪�� �訡�� � 䠩�: )
  if /i "!key!"=="Y" (move /y "%log1251%" "%~dp1"& del /q "%log866%") else (del /q "%log866%"& del /q "%log1251%")  
) else (del /q "%log866%")
Exit /B

:Recode
::���� � ����஢��� WIN-866
set FileIn=%log866%
::�������, �㤠 �����뢠�� OEM-1251
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
