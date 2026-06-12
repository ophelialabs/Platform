# DARPA NESD Command & Control Dashboard - Authentication System

## Overview

This Blazor application implements a mock **Entra-style authentication portal** with role-based access control (RBAC) for the DARPA NESD (Neuroergonomics-guided Enabled Support for Disaster response) Command & Control dashboard.

## Features

### Authentication
- **Mock Authentication System** - Simulates Entra/Azure AD authentication without external dependencies
- **Role-Based Access Control (RBAC)** - Two roles supported:
  - **Commander** - Full operational access to command and control functions
  - **Physician** - Medical personnel access to patient data and vital signs
- **Session Management** - Users can log in, log out, and their role is maintained across page navigation
- **User Profile Display** - Current user name and role shown in navigation menu

### User Interface
- **Entra-Inspired Login Portal** - Modern, gradient-based login page with role selection
- **Role-Specific Dashboards** - Different dashboard views for commanders vs physicians
- **Role-Based Navigation** - Navigation menu shows different sections based on user role
- **Command Center Theme** - Professional military-inspired design with gradients and icons

## Architecture

### Components

#### Authentication Services
- **`Services/AuthService.cs`** - Core authentication service managing user state and roles
  - `Login(userName, role)` - Authenticate a user with a specific role
  - `Logout()` - Clear authentication state
  - `IsAuthenticated` - Property to check if user is logged in
  - `HasRole(role)` - Check if user has a specific role

#### Pages
- **`Pages/Login.razor`** - Authentication page with role selection
  - Two buttons for Commander/Physician role selection
  - Styled as a modern Entra-like portal
  - Redirects to dashboard after authentication

#### Layouts
- **`Layout/MainLayout.razor`** - Standard application layout for authenticated users
  - Displays navigation menu and main content
  - Shows role-specific navigation items
- **`Layout/AuthLayout.razor`** - Layout for unauthenticated users
  - Redirects to login page
  - Used for routes accessed without authentication

#### Components
- **`CommanderOnly.razor`** - Wrapper component showing content only to commanders
- **`PhysicianOnly.razor`** - Wrapper component showing content only to physicians
- **`Dashboards/CommanderDashboard.razor`** - Commander-specific dashboard with operational metrics
- **`Dashboards/PhysicianDashboard.razor`** - Physician-specific dashboard with patient data

#### Navigation
- **`Layout/NavMenu.razor`** - Enhanced navigation menu with:
  - Role-specific menu sections
  - User profile display
  - Logout button

### Routing

Protected routes work as follows:
1. User accesses any page
2. If unauthenticated → Redirected to `/login` via `AuthLayout`
3. If authenticated → Route rendered with `MainLayout`
4. Role-specific components render/hide based on `AuthService.HasRole(role)`

## Usage

### Logging In
1. Navigate to `/login` (automatic if not authenticated)
2. Click the Commander or Physician button
3. Dashboard loads with role-specific content

### Role-Based Access
Use the `CommanderOnly` and `PhysicianOnly` components to conditionally render content:

```razor
@* Show only to commanders *@
<CommanderOnly>
    <div>Commander-only content</div>
</CommanderOnly>

@* Show only to physicians *@
<PhysicianOnly>
    <div>Physician-only content</div>
</PhysicianOnly>
```

Check roles programmatically:
```csharp
@if (AuthService.HasRole("commander"))
{
    <OperationsPanel />
}
```

### Logging Out
Click the sign-out button in the navigation menu (bottom left) to log out and return to login page.

## Project Structure

```
cmd_cntr/
├── Components/
│   ├── Pages/
│   │   ├── Login.razor              (Auth portal)
│   │   ├── Home.razor               (Dashboard)
│   │   └── ...
│   ├── Layout/
│   │   ├── MainLayout.razor         (Main app layout)
│   │   ├── AuthLayout.razor         (Auth redirect layout)
│   │   └── NavMenu.razor            (Navigation menu)
│   ├── Dashboards/
│   │   ├── CommanderDashboard.razor (Commander view)
│   │   └── PhysicianDashboard.razor (Physician view)
│   ├── CommanderOnly.razor          (Commander-only wrapper)
│   ├── PhysicianOnly.razor          (Physician-only wrapper)
│   ├── Routes.razor                 (App routing)
│   ├── App.razor                    (Root component)
│   └── _Imports.razor               (Global imports)
├── Services/
│   └── AuthService.cs               (Authentication service)
└── Program.cs                       (DI setup)
```

## Service Registration

The authentication service is registered in `Program.cs`:

```csharp
builder.Services.AddScoped<AuthService>();
```

This makes `AuthService` available via dependency injection throughout the app.

## Styling

The application uses:
- **Fluent UI Components** - Microsoft's Fluent Design System
- **Custom Cascading Styles** - Role-specific color themes
  - Commander: Purple gradient (`#667eea` → `#764ba2`)
  - Physician: Cyan gradient (`#06b6d4` → `#0891b2`)
- **Responsive Design** - Works on desktop and mobile devices

## Entra Portal Features Replicated

✅ Role-based authentication
✅ User profile display
✅ Sign-out functionality
✅ Protected routes
✅ Session persistence (during app lifetime)
✅ Role-specific UI elements
✅ Modern authentication UI

## Future Enhancements

To integrate with real Microsoft Entra ID:
1. Add `Microsoft.AspNetCore.Authentication.AzureAD.UI` NuGet package
2. Configure Azure AD authentication in `Program.cs`
3. Replace `AuthService` with real Entra authentication
4. Update login page to use Entra sign-in
5. Leverage `User.IsInRole()` for authorization

## Security Notes

⚠️ **This is a mock authentication system for demonstration purposes only.**
- No passwords are required
- Session state is in-memory and lost on app restart
- No data is persisted
- For production use, implement real authentication with proper security measures

For production deployment, use:
- Microsoft Entra ID (Azure AD) for authentication
- HTTPS only
- Secure session management
- Proper RBAC with database-backed roles
- Input validation and security headers
