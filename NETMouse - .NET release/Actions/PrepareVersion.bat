@echo off
title PrepareVersion
setlocal

Rem = = = = = = = = = = = = = = = = = = = = = = = = = = =

echo ============================================== %~dp0 ==============================================

set "dllPath=%~1ABCNET.dll"
set "xmlPath=%~1ABCNET.xml"
set "examplesFolder=%~2NETMouse - .NET release\Examples\"
set "preparedReleaseFolder=%~2Prepared release\"

Rem = = = = = = = = = = = = = = = = = = = = = = = = = = =

set "error=File not found: "

echo Files copying...

if not exist "%dllPath%" (
	echo %error%%dllPath%
	pause
	exit 1
) else copy "%dllPath%" "%examplesFolder%"

if not exist "%xmlPath%" (
	echo %error%%xmlPath%
	pause
	exit 1
) else copy "%xmlPath%" "%examplesFolder%"

echo Files have been successfully copied.

Rem = = = = = = = = = = = = = = = = = = = = = = = = = = =



endlocal