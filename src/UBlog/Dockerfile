#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["UBlog/UBlog.csproj", "UBlog/"]
RUN dotnet restore "UBlog/UBlog.csproj"
COPY . .
WORKDIR "/src/UBlog"
RUN dotnet build "UBlog.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "UBlog.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "UBlog.dll"]
