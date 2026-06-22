# Getting Started
- [Fluent-UI](https://www.fluentui-blazor.net/)
  | [AD](https://entra.microsoft.com)
  | [Figma](https://www.figma.com/community/file/1547572228024625595/sharepoint-intranet-design-templates)
- [Generic Constraints](https://www.youtube.com/watch?v=0qtwYT4n2CM) / [.NET 2026](https://www.youtube.com/watch?v=WYBZTraXlXQ)

## Dashboards
### Commander Dashboard
![banner](<wwwroot/assets/app/Adobe Express - Screen Recording 2026-06-22 at 5.42.21 PM.gif>)
- When user is selected from commanderdashboard table, display: user profile, **live-view**, fincen dashboard etc
- [Fleet](https://ophelialabs.github.io/c2/html/d3.html)
- APIs:

### Physician Dashboard
![banner](<wwwroot/assets/app/Screenshot 2026-06-22 at 6.02.56 PM.png>)
- [View Physician Dashboard](https://www.telerik.com/design-system/docs/templates/previews/healthcare-dashboard/)
    | [Kendo React Health App](https://telerik.github.io/kendo-react/react-health-app/#/)
    | [Blazor Healthcare Dashboard](https://demos.telerik.com/blazor-healthcare/patients)
    | [.NET Core Healthcare Dashboard](https://demos.telerik.com/aspnet-core-healthcare/patients)
- APIs:
     [DABI](https://dabi.loni.usc.edu/)
    | [DANDI](https://www.braininitiative.org/toolmakers/resources/dandi/)
    | [BrainRender](https://github.com/brainglobe/brainrender)
- Refs:
     [DartBrains](https://dartbrains.org/Introduction_to_Neuroimaging_Data/)

### Financial Dashboard
- [View Fintech Dashboard](https://www.telerik.com/design-system/docs/templates/previews/fintech-dashboard/)
    | [Kendo React Personal Finance](https://telerik.github.io/kendo-react/kendo-react-personal-finance/transactions)
    | [Blazor Financial Dashboard](https://demos.telerik.com/blazor-financial-dashboard)
    | [.Net Core Finance Dashboard](https://demos.telerik.com/aspnet-core/finance-dashboard)
- APIs:

### C2
![banner](<wwwroot/assets/app/Screenshot 2026-06-22 at 6.10.35 PM.png>)
![banner](<wwwroot/assets/app/221E99F5-3D39-405D-B593-E46C0321336B_1_102_a.jpeg>)
- [Saturn](https://ophelialabs.github.io/internal/apps/saturn.html)
    | [2](https://ophelialabs.github.io/c2/html/d2.html)
    | [qnet](https://ophelialabs.github.io/c2/html/qnet.html)
    | [Syglass](https://www.syglass.io/)

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

## Deployment
- [Microsoft Azure App Service](https://azure.microsoft.com/en-us/services/app-service/)
| [Heroku](https://www.heroku.com/)
| [Vultr App Deployment](https://www.vultr.com/products/app-deployment/)
| [Linode App Platform](https://www.linode.com/products/app-platform/)
| [AppVeyor](https://www.appveyor.com/)
| [Fly.io](https://www.fly.io/)
| [Render](https://www.render.com/)
| [Netlify](https://www.netlify.com/)
| [Avalonia](https://avaloniaui.net/)
| [CloudFlare](https://www.heroku.com/)
| [Octopus](https://octopus.com/)
