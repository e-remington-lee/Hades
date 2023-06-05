FROM mcr.microsoft.com/dotnet/sdk:6.0-focal AS build
WORKDIR /app

EXPOSE 8080
EXPOSE 8081
EXPOSE 8082
EXPOSE 9090
EXPOSE 80

COPY . .
RUN dotnet restore

WORKDIR /app/Hades
RUN dotnet publish -c release -o /out --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:6.0-focal AS runtime
WORKDIR /app
COPY --from=build /out .

EXPOSE 80
EXPOSE 5672
EXPOSE 15672

ENTRYPOINT ["dotnet", "Hades.dll"]