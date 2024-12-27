# Use the official .NET SDK image to build and run the application
FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80

# Build stage
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["GymApplication.csproj", "./"]
RUN dotnet restore "GymApplication.csproj"
COPY . .
WORKDIR "/src/"
RUN dotnet publish "GymApplication.csproj" -c Release -o /app/publish

# Runtime stage
FROM base AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "GymApplication.dll"]
