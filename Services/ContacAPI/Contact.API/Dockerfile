#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Services/ContacAPI/Contact.API/Contact.API.csproj", "Services/ContacAPI/Contact.API/"]
COPY ["Services/ContacAPI/Contact.API.Infrastructure/Contact.API.Infrastructure.csproj", "Services/ContacAPI/Contact.API.Infrastructure/"]
COPY ["Services/ContacAPI/Contact.API.Models/Contact.API.Models.csproj", "Services/ContacAPI/Contact.API.Models/"]
COPY ["Services/ContacAPI/Contact.API.Services/Contact.API.Services.csproj", "Services/ContacAPI/Contact.API.Services/"]
RUN dotnet restore "Services/ContacAPI/Contact.API/Contact.API.csproj"
COPY . .
WORKDIR "/src/Services/ContacAPI/Contact.API"
RUN dotnet build "Contact.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Contact.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Contact.API.dll"]