FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["DockerEx5/DockerEx5.csproj", "DockerEx5/"]
RUN dotnet restore "DockerEx5/DockerEx5.csproj"
COPY . .
WORKDIR "/src/DockerEx5"
RUN dotnet build "./DockerEx5.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./DockerEx5.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

# WICHTIG: Als root anmelden, um Ordner zu erstellen und Rechte zu setzen
USER root
RUN mkdir -p /app/persistent && chown -R app:app /app/persistent

# Das Volume definieren
VOLUME ["/app/persistent"]

# Zurück zum sicheren User wechseln
USER app
ENTRYPOINT ["dotnet", "DockerEx5.dll"]