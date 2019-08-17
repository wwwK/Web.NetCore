FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["Web.NetCore/Web.NetCore.csproj", "Web.NetCore/"]
RUN dotnet restore "Web.NetCore/Web.NetCore.csproj"
COPY . .
WORKDIR "/src/Web.NetCore"
RUN dotnet build "Web.NetCore.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Web.NetCore.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Web.NetCore.dll"]