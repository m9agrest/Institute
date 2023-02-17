@echo off
set /a x=0
set /a c=0
call :WriteNumber "Введите X: " x || goto :eof
call :WriteNumber "Введите C: " c || goto :eof
set /a y=0
if %x% geq 0 (
	set /a y=%x%+%x%
) else if %x% lss 0 if %x% geq -1 (
	set /a num=0
	call :Pow %c% 4 num
	set /a y=7*num
) else (
	set /a num=0
	call :Pow %x% 2 num
	set /a y=%x%+num+%c%
)
echo %y%
pause
exit /b 0
:WriteNumber
	SetLocal EnableExtensions EnableDelayedExpansion
	set /p return=%1
	echo %return%|findstr "^[-][1-9][0-9]*$ ^[1-9][0-9]*$ ^0$">nul
	if %errorlevel% neq 0 (
		echo %return% is not number
		pause
		exit /b 1
	)
	endlocal & set /a %2=%return%
	exit /b 0
:Pow
	SetLocal EnableExtensions EnableDelayedExpansion
	set /a number=%1
	set /a power=%2
	set /a return=1
	if %power% lss 0 (
		set /a return=0
	) else if %power% gtr 0 (
		for /l %%i in (1,1,%power%) do (
			set /a return*=%number%
		)
	)
	endlocal & set /a %3=%return%
	exit /b 0