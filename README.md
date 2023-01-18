# AspNetCoreMVCCleanArc

# Asp.net core 7 with clean

# Create a solution file in AspNetCoreMVCCleanArc

```sh
dotnet new sln --name MvcCleanArc
```

Then create two directory src and test
Create projects inside src folder
Create MvcCleanArc.Core library project

```sh
dotnet new classlib --name MvcCleanArc.Core
```

Create MvcCleanArc.Infrastructure library project

```sh
dotnet new classlib --name MvcCleanArc.Infrastructure
```

Create MvcCleanArc.Application library project

```sh
dotnet new classlib --name MvcCleanArc.Application
```

Create MvcCleanArc.Web library project

```sh
dotnet new mvc --name MvcCleanArc.Web
```

Then add projects to the solution file

```sh
dotnet new sln
```
