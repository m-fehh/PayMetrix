FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /src
COPY ["src/PayMetrix.Web.Host/PayMetrix.Web.Host.csproj", "src/PayMetrix.Web.Host/"]
COPY ["src/PayMetrix.Web.Core/PayMetrix.Web.Core.csproj", "src/PayMetrix.Web.Core/"]
COPY ["src/PayMetrix.Application/PayMetrix.Application.csproj", "src/PayMetrix.Application/"]
COPY ["src/PayMetrix.Core/PayMetrix.Core.csproj", "src/PayMetrix.Core/"]
COPY ["src/PayMetrix.EntityFrameworkCore/PayMetrix.EntityFrameworkCore.csproj", "src/PayMetrix.EntityFrameworkCore/"]
WORKDIR "/src/src/PayMetrix.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/PayMetrix.Web.Host", "src/PayMetrix.Web.Host"]
COPY ["src/PayMetrix.Web.Core", "src/PayMetrix.Web.Core"]
COPY ["src/PayMetrix.Application", "src/PayMetrix.Application"]
COPY ["src/PayMetrix.Core", "src/PayMetrix.Core"]
COPY ["src/PayMetrix.EntityFrameworkCore", "src/PayMetrix.EntityFrameworkCore"]
WORKDIR "/src/src/PayMetrix.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "PayMetrix.Web.Host.dll"]
