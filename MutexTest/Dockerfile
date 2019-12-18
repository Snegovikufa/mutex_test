FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
COPY . /src/MutexTest
WORKDIR "/src/MutexTest"
RUN dotnet restore "/src/MutexTest/MutexTest.csproj"
RUN dotnet build "MutexTest.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MutexTest.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish /app
COPY run.sh /app
RUN chmod +x /app/run.sh
ENTRYPOINT /app/run.sh