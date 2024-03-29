FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env

WORKDIR /app

COPY ./bin/Debug/net7.0/ .

CMD ["dotnet", "AndreasOscar.dll"]
