@echo off
REM Run all tests in the "test" folder
setlocal

set SCRIPT_DIR=%~dp0

for /R "%SCRIPT_DIR%test" %%f in (*.csproj) do (
    echo Running tests for %%f
    dotnet test "%%f" || exit /b 1
)

echo All tests passed.
endlocal
