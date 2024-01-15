FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["FileWriterDemo/FileWriterDemo.csproj", "FileWriterDemo/"]
RUN dotnet restore "FileWriterDemo/FileWriterDemo.csproj"
COPY . .
WORKDIR "/src/FileWriterDemo"
RUN dotnet build "FileWriterDemo.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "FileWriterDemo.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FileWriterDemo.dll"]
