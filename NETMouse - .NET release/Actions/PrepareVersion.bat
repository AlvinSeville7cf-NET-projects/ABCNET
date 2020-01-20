@echo off
title PrepareVersion
setlocal

Rem = = = = = = = = = = = = = = = = = = = = = = = = = = =

set "dllPath=..\bin\Release\ABCNET.dll"
set "xmlPath=..\bin\Release\ABCNET.xml"
set "examplesFolder=..\Examples\"
set "preparedReleaseFolder=..\Prepared release\"

Rem = = = = = = = = = = = = = = = = = = = = = = = = = = =

set "error=File not found: "

echo Files copying...

if not exist %dllPath% (
	echo %error%%dllPath%
	pause
	exit 1
) else copy %dllPath% %examplesFolder%

if not exist %xmlPath% (
	echo %error%%xmlPath%
	pause
	exit 1
) else copy %xmlPath% %examplesFolder%

echo Files have been successfully copied.

Rem = = = = = = = = = = = = = = = = = = = = = = = = = = =



endlocal