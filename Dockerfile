FROM mcr.microsoft.com/dotnet/aspnet:5.0.9
# COPY bin/Release/net5.0/publish/ App/
COPY bin/Debug/net5.0/publish/ App/
WORKDIR /App
ENV ASPNETCORE_ENVIRONMENT=Development
ENV DOTNET_EnableDiagnostics=0
ENV COMPlus_EnableDiagnostics=0
ENTRYPOINT ["dotnet", "NullOp.dll"]
