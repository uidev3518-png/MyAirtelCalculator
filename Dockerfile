# 1. SDK image use karein build ke liye
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build-env
WORKDIR /app

# 2. Project file copy karein aur restore karein
COPY *.csproj ./
RUN dotnet restore

# 3. Baaki saara code copy karein aur publish karein
COPY . ./
RUN dotnet publish -c Release -o out

# 4. Runtime image banayein
FROM mcr.microsoft.com/dotnet/aspnet:9.0
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "YourAppName.dll"]