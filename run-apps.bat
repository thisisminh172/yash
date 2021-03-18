@ECHO OFF 

ECHO ============================
ECHO Please wait...
ECHO ============================



REM start cmd.exe /k "dotnet dev-certs https --trust"

cd /d ..\yash\yash.WebApi
start cmd.exe /k "dotnet run --project .\yash.WebApi.csproj --urls=http://localhost:58960 /property:Configuration=Release"
cd /d ..\yash\yash.WebApp
start cmd.exe /k "dotnet run --project .\yash.WebApp.csproj --urls=http://localhost:58667 /property:Configuration=Release"
cd /d ..\yash\yash.AdminApp
start cmd.exe /k "dotnet run --project .\yash.AdminApp.csproj --urls=http://localhost:62948 /property:Configuration=Release"


