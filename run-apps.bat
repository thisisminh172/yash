@ECHO OFF 

ECHO ============================
ECHO Please wait...
ECHO ============================



REM start cmd.exe /k "dotnet dev-certs https --trust"

cd /d .\yash.WebApi
start cmd.exe /k "dotnet run .\yash.WebApi.csproj --urls=http://localhost:58960 /property:Configuration=Release"
cd /d .\yash.WebApp
start cmd.exe /k "dotnet run .\yash.WebApp.csproj --urls=http://localhost:58667 /property:Configuration=Release"
cd /d .\yash.AdminApp
start cmd.exe /k "dotnet run .\yash.AdminApp.csproj --urls=http://localhost:62948 /property:Configuration=Release"


