:: In case this bat file doesn't execute properly on your machine, follow the steps below
:: 
:: Copy the code from lines to 10 through 33
:: Paste and execute this code in an Elevated (Run as Administrator) Developer Command Prompt for VS 2022

:: This line adds the VS Developer Command Prompt bat script to run the msbuild.exe & vstest.console.exe commands
call "D:\Program Files\Microsoft Visual Studio\VC\Auxiliary\Build\vcvarsall.bat" x86

:: Switch directory to the project
D:
cd D:\Git_Projects\CPSC5210-TEAM7\
@echo off
set /p email=Enter Email to Send Results To:

:: Build the project solution and log the results
msbuild.exe D:\Git_Projects\CPSC5210-TEAM7\Pacman.sln -fileLogger
SET buildResults=%cd%\msbuild.log

:: Run all project tests and log the results
vstest.console.exe D:\Git_Projects\CPSC5210-TEAM7\UnitTestProject1\bin\Debug\UnitTestProject1.dll /TestAdapterPath:D:\Git_Projects\CPSC5210-TEAM7\packages\MSTest.TestAdapter.2.2.10\build\_common /logger:trx

cd TestResults
for /f %i in ('dir /b/a-d/od/t:c') do set latestTest=%i
echo Most recent subfolder: %latestTest%

:: Add your SMTP email & password credentials
SET username="" 
SET password=""
SET testResults=%cd%\%latestTest%

cd ..

powershell -ExecutionPolicy Bypass -Command "& '.\sendEmailScript.ps1' '%username%' '%password%' '%testResults%' '%buildResults%' '%email%'"
