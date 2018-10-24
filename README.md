# Tardis

[![Build Status](https://travis-ci.com/avitsidis/Tardis.svg?branch=master)](https://travis-ci.com/avitsidis/Tardis)
[![NuGet](https://img.shields.io/nuget/v/Tardis.svg?style=flat)](https://www.nuget.org/packages/Tardis/)
[![Build status](https://ci.appveyor.com/api/projects/status/ntaa0qyxw0nwcvr1?svg=true)](https://ci.appveyor.com/project/avitsidis/tardis)
[![Build status](https://ci.appveyor.com/api/projects/status/ntaa0qyxw0nwcvr1/branch/master?svg=true)](https://ci.appveyor.com/project/avitsidis/tardis/branch/master)

## Description

Tardis is POC library defining a mockable DateService. I use this project to test how to publish package in nuget and configure it with online CI

## Publish to nuget

``` bash
dotnet build -c Release
dotnet test
dotnet pack -c Release
dotnet nuget push Tardis\bin\Release\Tardis.0.0.0.nupkg -k {API_KEY} -s https://api.nuget.org/v3/index.json
```