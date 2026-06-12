# Getting Started
- [Fluent-UI](https://www.fluentui-blazor.net/)
  | [AD](https://entra.microsoft.com)

## Dashboards
### C2
- [Saturn](https://ophelialabs.github.io/internal/apps/saturn.html)
    | [2](https://ophelialabs.github.io/c2/html/d2.html)
    | [qnet](https://ophelialabs.github.io/c2/html/qnet.html)
    | [Syglass](https://www.syglass.io/)

### Commander Dashboard
- [Fleet](https://ophelialabs.github.io/c2/html/d3.html)
- APIs here
    | [DABI](https://dabi.loni.usc.edu/)
    | [DANDI](https://www.braininitiative.org/toolmakers/resources/dandi/)

### Physician Dashboard
- [View Physician Dashboard](https://www.telerik.com/design-system/docs/templates/previews/healthcare-dashboard/)
    | [Kendo React Health App](https://telerik.github.io/kendo-react/react-health-app/#/)
    | [Blazor Healthcare Dashboard](https://demos.telerik.com/blazor-healthcare/patients)
    | [.NET Core Healthcare Dashboard](https://demos.telerik.com/aspnet-core-healthcare/patients)
- APIs here
    

### Financial Dashboard
- [View Fintech Dashboard](https://www.telerik.com/design-system/docs/templates/previews/fintech-dashboard/)
    | [Kendo React Personal Finance](https://telerik.github.io/kendo-react/kendo-react-personal-finance/transactions)
    | [Blazor Financial Dashboard](https://demos.telerik.com/blazor-financial-dashboard)
    | [.Net Core Finance Dashboard](https://demos.telerik.com/aspnet-core/finance-dashboard)
- APIs here

## DataBase
- [EF Core](https://learn.microsoft.com/en-us/ef/core/providers/?tabs=dotnet-core-cli)
    1. Code-First (Recommended): You write your C# entity classes and configurations first. EF Core's engine then automatically scaffolds and builds out your underlying physical database tables through migrations.
    2. Database-First: You point EF Core toward a pre-existing target database. Utilizing the command-line design tools, EF Core reverse-engineers the database schema to automatically generate your C# entity classes and DbContext files.

To install the framework package for an application, you pull down the provider library specific to your target database engine via NuGet:
```
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
```

Once installed, managing data transactions follows an expressive, object-oriented workflow:
```csharp
// csharp
// Define a basic database session 
using var db = new BloggingContext();

// Create and Insert a record without writing "INSERT INTO..."
db.Add(new Blog { Url = "https://devblogs.microsoft.com/dotnet" });
db.SaveChanges(); 

// Read data using strongly-typed LINQ statements
var blog = db.Blogs.OrderBy(b => b.BlogId).First();

// Update tracking handles persistence cleanly
blog.Url = "https://learn.microsoft.com/en-us/ef/core/";
db.SaveChanges();
```


