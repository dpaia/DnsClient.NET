@echo off
REM Run all tests in the "test" folder targeting .NET 8.0
setlocal

set SCRIPT_DIR=%~dp0

for /R "%SCRIPT_DIR%test" %%f in (*.csproj) do (
    echo Running tests for %%f
    dotnet test "%%f" --framework net8.0 || exit /b 1
)

echo All tests passed.
endlocal
