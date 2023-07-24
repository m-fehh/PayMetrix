FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

RUN dotnet tool install -g Microsoft.Web.LibraryManager.Cli
RUN ln -s ~/.dotnet/tools/libman /usr/local/bin/libman

WORKDIR /src
COPY ["src/PayMetrix.Web.Mvc/PayMetrix.Web.Mvc.csproj", "src/PayMetrix.Web.Mvc/"]
COPY ["src/PayMetrix.Web.Core/PayMetrix.Web.Core.csproj", "src/PayMetrix.Web.Core/"]
COPY ["src/PayMetrix.Application/PayMetrix.Application.csproj", "src/PayMetrix.Application/"]
COPY ["src/PayMetrix.Core/PayMetrix.Core.csproj", "src/PayMetrix.Core/"]
COPY ["src/PayMetrix.EntityFrameworkCore/PayMetrix.EntityFrameworkCore.csproj", "src/PayMetrix.EntityFrameworkCore/"]
WORKDIR "/src/src/PayMetrix.Web.Mvc"
RUN dotnet restore 

WORKDIR /src
COPY ["src/PayMetrix.Web.Mvc", "src/PayMetrix.Web.Mvc"]
COPY ["src/PayMetrix.Web.Core", "src/PayMetrix.Web.Core"]
COPY ["src/PayMetrix.Application", "src/PayMetrix.Application"]
COPY ["src/PayMetrix.Core", "src/PayMetrix.Core"]
COPY ["src/PayMetrix.EntityFrameworkCore", "src/PayMetrix.EntityFrameworkCore"]
WORKDIR "/src/src/PayMetrix.Web.Mvc"
RUN libman restore
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "PayMetrix.Web.Mvc.dll"]
