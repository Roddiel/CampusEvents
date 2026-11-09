# Campus Events Management System (CEMS)

Course Project #1 — server-rendered ASP.NET Core MVC application.

## Prerequisites

- .NET 10.x SDK

## Run from the solution folder

```cmd
dotnet build
dotnet test
dotnet run --project src/CampusEvents
```

If you want to use HTTPS run:

```cmd
dotnet dev-certs https --trust
```

once, from then on only this:

```cmd
dotnet run --project src/CampusEvents --launch-profile https
```

If dependency restore reports a vulnerability, inspect the package advisory. Update the affected direct dependency to a compatible patched version, then rebuild and retest.

```cmd
dotnet package update --vulnerable --project src/CampusEvents
```

Open the URL printed by the application and select Events.

## Current scope

The application serves Home, Privacy, and Events pages through MVC, with shared navigation, project-owned CSS, and a controller-provided event title. It also includes an xUnit test project.
