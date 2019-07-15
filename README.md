# Simple Prime Service

[![Build Status](https://dev.azure.com/csudemos/SimplePrimeService/_apis/build/status/SimplePrimeService-ASP.NET-Core-CI?branchName=master)](https://dev.azure.com/csudemos/SimplePrimeService/_build/latest?definitionId=16&branchName=master)

A Simple ASP.NET Core web page using Razor Pages that shows how to create a CI/CD pipeline using Azure DevOps.

As part of the CI/CD pipeline it performs the following tasks:
* Integration with GitHub for automatic triggers when you push to master branch or creates a PR.
* Runs and publishes unit tests.
* Deploys the application into an Azure Web App.
* Integration with Azure Boards, which allows you to automatically close tasks when a PR is approved or a commit is pushed to master branch.

## Pre-requisites
It is assumed that you have access to an Azure Subscription and to an Azure DevOps Project. 

### versions
This project was built and tested using:
* .Net Core 2.2.300
* xunit 2.4.0


## Project Structure
```
.
|-- src
|   `-- PrimeServiceProject
|       |-- Pages
|       |   `-- Shared
|       |-- Properties
|       |-- bin
|       |   `-- Debug
|       |       `-- netcoreapp2.2
|       |-- obj
|       |   `-- Debug
|       |       `-- netcoreapp2.2
|       |           `-- Razor
|       |               `-- Pages
|       |                   `-- Shared
|       `-- wwwroot
|           |-- css
|           |-- js
|           `-- lib
|               |-- bootstrap
|               |   `-- dist
|               |       |-- css
|               |       `-- js
|               |-- jquery
|               |   `-- dist
|               |-- jquery-validation
|               |   `-- dist
|               `-- jquery-validation-unobtrusive
`-- tests
    `-- PrimeServiceProject.Tests
        |-- bin
        |   `-- Debug
        |       `-- netcoreapp2.2
        `-- obj
            `-- Debug
                `-- netcoreapp2.2
```
## Usage
To run the tests
```
dotnet test tests/PrimeServiceProject.Tests/PrimeServiceProject.Tests.csproj
```

To run it locally
```
dotnet run -p src/PrimeServiceProject/PrimeServiceProject.csproj
```

To build it
```
dotnet build --no-restore
```

## Resources
* Get Started with Razor Pages in ASP.NET Core
    * https://docs.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/razor-pages-start
* Razor Pages unit tests in ASP.NET Core
    * https://docs.microsoft.com/en-us/aspnet/core/test/razor-pages-tests?view=aspnetcore-2.2
* Unit testing C# in .NET Core using dotnet test and xUnit
    * https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-dotnet-test
* Organizing and testing projects with the .NET Core command line
    * https://docs.microsoft.com/en-us/dotnet/core/tutorials/testing-with-cli
* Create an ASP.NET Core app in App Service on Linux
    * https://docs.microsoft.com/en-us/azure/app-service/containers/quickstart-dotnetcore
* Build, test, and deploy .NET Core apps using Azure DevOps
    * https://docs.microsoft.com/en-us/azure/devops/pipelines/languages/dotnet-core?view=azure-devops
