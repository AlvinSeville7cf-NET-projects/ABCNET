@echo off
title PrepareVersion
setlocal

Rem = = = = = = = = = = = = = = = = = = = = = = = = = = =

set "dllPath=%~1ABCNET.dll"
set "xmlPath=%~1ABCNET.xml"
set "pascalExamplesFolder=%~2NETMouse - .NET release\Examples\PascalABC.NET\"
set "csharpExamplesFolder=%~2NETMouse - .NET release\Examples\C#\"
set "preparedReleaseFolder=%~2Prepared release\"

set "copyingError=[CRITICAL ERROR] ABCNET.dll or ABCNET.xml file or folder to copy files to not found: "

echo Files copying...

if not exist "%pascalExamplesFolder%" (
	echo %copyingError%%pascalExamplesFolder%
	pause
	exit 1
)

if not exist "%csharpExamplesFolder%" (
	echo %copyingError%%csharpExamplesFolder%
	pause
	exit 1
)

if not exist "%dllPath%" (
	echo %copyingError%%dllPath%
	pause
	exit 1
)

copy "%dllPath%" "%pascalExamplesFolder%"
copy "%dllPath%" "%csharpExamplesFolder%"


if not exist "%xmlPath%" (
	echo %copyingError%%xmlPath%
	pause
	exit 1
)

copy "%xmlPath%" "%pascalExamplesFolder%"
copy "%xmlPath%" "%csharpExamplesFolder%"

echo Files have been successfully copied.

Rem = = = = = = = = = = = = = = = = = = = = = = = = = = =

set "pascalabcnetCompiler=C:\Program Files (x86)\PascalABC.NET\pabcnetcclear.exe"

set "compilationError=[CRITICAL ERROR] pabcnetc.exe file not found: "

echo Examples recompiling...

if not exist "%pascalabcnetCompiler%" (
	echo "%compilationError%%pascalabcnetCompiler%"
	pause
	exit 1
)

for %%f in ("%pascalExamplesFolder%*.pas") do "%pascalabcnetCompiler%" "%%f"

echo Examples have been successfully recompiled.

Rem = = = = = = = = = = = = = = = = = = = = = = = = = = =

echo Files archiving...

echo Files have been successfully archived.

endlocal