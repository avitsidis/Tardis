# Tardis

Tardis is POC library defining a mockable DateService. I use this project to test how to publish package in nuget and configure it with online CI

## Publish to nuget

``` bash
dotnet build -c Release
dotnet test
 dotnet pack -c Release
dotnet nuget push Tardis\bin\Release\Tardis.0.0.0.nupkg -k {API_KEY} -s https://api.nuget.org/v3/index.json
```