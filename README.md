# 🚘 Auto Management System

A modern **ASP.NET Core MVC** web application for managing vehicle listings, rentals, and sales. This system provides a user-friendly platform for users to browse, add, edit, and manage vehicles, with built-in authentication and role-based access control.

---

## Features:

- User Authentication & Role Management (via ASP.NET Core Identity)
- Vehicle Listing: Add, edit, and delete vehicles
- Vehicle Categories: Rent or Sale
- User Profile Management
- Admin Panel for vehicle management
- Entity Framework Core + SQL Server support
- Razor View Pages for a responsive UI

---

## Tech Stack:

| Category       | Tech                                  |
|----------------|----------------------------------------|
| Framework      | ASP.NET Core MVC                      |
| Language       | C#                                    |
| ORM            | Entity Framework Core                 |
| Database       | SQL Server / LocalDB                  |
| Authentication | ASP.NET Identity                      |
| Frontend       | Razor Pages, Bootstrap (optional)     |
| IDE            | Visual Studio 2022+ / Rider           |

---

## Project Structure:

```plaintext
Autos/
├── Controllers/
│   ├── HomeController.cs
│   └── ManageVehicleController.cs
├── Models/
│   ├── Vehicle.cs
│   ├── User.cs
│   ├── Sale.cs
│   ├── Rental.cs
│   └── ErrorViewModel.cs
├── Data/
│   └── AutoDbContext.cs
├── Views/
│   ├── Home/
│   ├── ManageVehicle/
│   └── Shared/
├── Areas/Identity/Pages/        # Authentication pages
├── Migrations/                  # EF Core migrations
├── wwwroot/                     # Static assets (CSS, JS, images)
├── appsettings.json
├── Program.cs
├── Autos.csproj
└── Autos.sln
```


---

## Getting Started

### Prerequisites:

- [.NET 6.0 SDK](https://dotnet.microsoft.com/download)
- [Visual Studio 2022+](https://visualstudio.microsoft.com/)
- SQL Server or LocalDB

---

### Setup Instructions:

#### 1. Clone the repository

```bash
git clone https://github.com/your-username/Auto-Management-System.git
cd Auto-Management-System
```

#### 2. Update the database connection
Edit appsettings.json:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=YOUR_SERVER;Database=AutoDb;Trusted_Connection=True;"
}
```

#### 3. Run database migrations
```bash
dotnet ef database update
```

#### 4. Run the application
```bash
dotnet run
```
Visit https://localhost:5001 in your browser.


---
##### Configuration:

appsettings.json: Main configuration for connection strings and logging.

AutoDbContext.cs: Defines the EF Core context and model bindings.

Identity Pages: Located in Areas/Identity/Pages for login, register, and user management.

