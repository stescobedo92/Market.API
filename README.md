# Market.API
Simple RESTful API built with NET 6 to show how to create RESTful services using a decoupled, maintainable architecture.

## Frameworks and Libraries
- [ASP.NET Core 2.2](https://docs.microsoft.com/pt-br/aspnet/core/?view=aspnetcore-2.2);
- [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/) (for data access);
- [Entity Framework In-Memory Provider](https://docs.microsoft.com/en-us/ef/core/miscellaneous/testing/in-memory) (for testing purposes);
- [AutoMapper](https://automapper.org/) (for mapping resources and models);
- [Swashbuckle](https://github.com/domaindrivendev/Swashbuckle) (API documentation).

## How to Test

First, install [NET 6](https://dotnet.microsoft.com/download/dotnet/6.0). Then, open the terminal or command prompt at the API root path (```/Market.API/```) and run the following commands, in sequence:

```
dotnet restore
dotnet run
```

Navigate to ```https://localhost:5001/api/categories``` to check if the API is working. If you see a HTTPS security error, just add an exception to see the results.

Navigate to ```https://localhost:5001/swagger``` to check the API documentation.
