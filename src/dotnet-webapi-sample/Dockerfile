FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["dotnet-webapi-sample/dotnet-webapi-sample.csproj", "dotnet-webapi-sample/"]
RUN dotnet restore "dotnet-webapi-sample/dotnet-webapi-sample.csproj"
COPY . .
WORKDIR "/src/dotnet-webapi-sample"
RUN dotnet build "dotnet-webapi-sample.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "dotnet-webapi-sample.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "dotnet-webapi-sample.dll"]