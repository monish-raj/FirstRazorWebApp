
# this was boilerplate added by VS when docker support was added.  
# it did not work, hence replaced with the section below
#
# FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
# WORKDIR /app
# EXPOSE 8080
# EXPOSE 8443

# FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
# WORKDIR /src
# COPY FirstRazorWebApp/FirstRazorWebApp.csproj FirstRazorWebApp/
# RUN dotnet restore "FirstRazorWebApp/FirstRazorWebApp.csproj"
# COPY . .
# WORKDIR "/src/FirstRazorWebApp"
# RUN dotnet build "FirstRazorWebApp.csproj" -c Release -o /app/build

# FROM build AS publish
# RUN dotnet publish "FirstRazorWebApp.csproj" -c Release -o /app/publish

# FROM base AS final
# WORKDIR /app
# COPY --from=publish /app/publish .
# ENTRYPOINT ["dotnet", "FirstRazorWebApp.dll"]


# this section was sourced from https://docs.docker.com/engine/examples/dotnetcore/
# simply replaced the source images based on the names above
# also added ENV setting appropriate port numbers 

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build-env
WORKDIR /app
# ENV ASPNETCORE_URLS=https://+:5443;http://+:5000
ENV ASPNETCORE_URLS=http://+:5000
EXPOSE 5000
# EXPOSE 5443

# Copy csproj and restore as distinct layers
COPY *.csproj ./
RUN dotnet restore

# Copy everything else and build
COPY . ./
RUN dotnet publish -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim
WORKDIR /app
COPY --from=build-env /app/out .
ENV ASPNETCORE_URLS=http://+:5000
EXPOSE 5000
ENTRYPOINT ["dotnet", "FirstRazorWebApp.dll"]

# inside project subdir, execute: docker build -t firstrazorwebapp .
# Run it using: docker run -d --rm -p 8080:80 --name webapp firstrazorwebapp
# -- or leave the port mapping out