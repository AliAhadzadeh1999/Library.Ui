# Insurance Management System

A desktop-based **Insurance Management System** developed using **C# and .NET 6**, with **Windows Forms** as the presentation layer and **Microsoft SQL Server** as the database.

The project is designed with a layered architecture to separate business logic, application services, domain models, data access, and the user interface.

## 🛠️ Technologies

* **C#**
* **.NET 6**
* **Windows Forms**
* **Entity Framework Core 6**
* **Microsoft SQL Server**
* **SQL**
* **Repository Pattern**
* **Dependency Injection**
* **Layered Architecture**
* **Entity Framework Core Migrations**

## 🏗️ Architecture

The solution is divided into multiple projects, with each layer having a specific responsibility:

```text
Library.Ui
│
├── Library.Model
│   └── Domain Models / Entities
│
├── Library.Application.Contract
│   └── Application Interfaces / Contracts
│
├── Library.Application
│   └── Application Services
│
├── Library.Infrastructure
│   ├── DbContext
│   ├── Repositories
│   ├── Repository Interfaces
│   ├── Database Connection
│   └── EF Core Migrations
│
└── Library.Ui
    ├── Windows Forms
    ├── Login
    ├── Insurance Management
    ├── Pharmacy Management
    └── Prescription Management
```

## 📂 Project Structure

### `Library.Model`

Contains the core domain models and entities used throughout the application.

This layer represents the main business objects of the system and does not depend on the UI or infrastructure implementation.

---

### `Library.Application.Contract`

Contains application-level contracts and interfaces.

The purpose of this layer is to define abstractions that can be implemented by the application services.

---

### `Library.Application`

Contains the application's business services and application logic.

This layer is responsible for coordinating application operations and communicating with the required abstractions.

---

### `Library.Infrastructure`

Responsible for communication with the database and implementation of data-access concerns.

It contains:

* Entity Framework Core `DbContext`
* Repository interfaces
* Repository implementations
* SQL Server configuration
* Database migrations
* Database connection configuration

The project uses **Entity Framework Core 6** together with the SQL Server provider.

---

### `Library.Ui`

The presentation layer of the application.

The UI is implemented using **Windows Forms** and contains the application's forms and user interactions.

Current forms include:

* Login Form
* Insurance Form
* Pharmacy Form
* Prescription Form

The UI project targets **.NET 6 for Windows** and uses Windows Forms.

## 🔄 Application Flow

The general flow of the application follows the layered architecture:

```text
User
 │
 ▼
Windows Forms UI
 │
 ▼
Application Services
 │
 ▼
Application Contracts
 │
 ▼
Repository
 │
 ▼
Entity Framework Core
 │
 ▼
SQL Server
```

This separation makes the application easier to maintain, test, and extend.

## 🗄️ Database

The application uses **Microsoft SQL Server** as its relational database.

Entity Framework Core is responsible for:

* Database access
* Entity mapping
* CRUD operations
* Change tracking
* Database migrations

Database migrations are maintained inside the `Library.Infrastructure/Migrations` directory.

## 🔐 Authentication

The application contains a dedicated login form for user authentication.

```text
Login
  │
  ▼
Validate Credentials
  │
  ▼
Application Service
  │
  ▼
Repository
  │
  ▼
SQL Server
  │
  ▼
Authentication Result
```

After successful authentication, the user can access the application's management features.

## 📋 Main Features

### Insurance Management

The system provides functionality for managing insurance-related information through the `InsuranceForm`.

### Pharmacy Management

The application includes a dedicated `PharmacyForm` for managing pharmacy-related information.

### Prescription Management

Prescription-related operations are handled through the `PrescriptionForm`.

### User Authentication

Users can authenticate through the application's login form before accessing the main functionality.

## 🧩 Design Principles

The project follows several software engineering principles:

* Separation of Concerns
* Single Responsibility Principle
* Dependency Inversion
* Abstraction through interfaces
* Layered Architecture
* Repository Pattern
* Service Layer Pattern

The main goal is to keep the UI independent from database implementation details.

## 🚀 Getting Started

### Prerequisites

Make sure the following tools are installed:

* .NET 6 SDK
* Visual Studio 2022 or compatible IDE
* Microsoft SQL Server
* SQL Server Management Studio (SSMS)

### Clone the Repository

```bash
git clone https://github.com/AliAhadzadeh1999/Library.Ui.git
```

### Open the Solution

Open:

```text
Library.Ui.sln
```

in Visual Studio.

### Configure the Database

Update the database connection string according to your SQL Server configuration.

The database configuration is located in the Infrastructure layer.

Example:

```text
Server=localhost;
Database=InsuranceDb;
Trusted_Connection=True;
TrustServerCertificate=True;
```

> Replace the connection string with the appropriate configuration for your environment.

### Apply Migrations

If the database has not been created yet, run the Entity Framework Core migrations:

```bash
dotnet ef database update
```

Or use the Package Manager Console in Visual Studio:

```powershell
Update-Database
```

### Run the Application

Build and run the `Library.Ui` project:

```bash
dotnet run
```

Alternatively, press **F5** in Visual Studio.

## 📦 Dependencies

The project uses Entity Framework Core packages including:

```text
Microsoft.EntityFrameworkCore
Microsoft.EntityFrameworkCore.Design
Microsoft.EntityFrameworkCore.SqlServer
Microsoft.EntityFrameworkCore.Tools
System.Data.SqlClient
```

The Infrastructure project uses EF Core `6.0.28` and the SQL Server provider.

## 🎯 Project Goals

The main goals of this project are:

* Building a real-world desktop application using C#
* Applying layered architecture
* Separating business logic from infrastructure
* Working with Entity Framework Core
* Implementing Repository Pattern
* Working with SQL Server
* Managing database schema using EF Core migrations
* Building a maintainable Windows Forms application

## 🔮 Future Improvements

Possible future improvements include:

* Adding comprehensive unit tests
* Improving validation and error handling
* Adding centralized exception handling
* Improving authentication and authorization
* Adding logging
* Improving UI/UX
* Adding reporting and analytics
* Adding automated database configuration
* Migrating the UI to a modern web-based architecture

## 👨‍💻 Author

**Ali Ahadzadeh**

GitHub:
https://github.com/AliAhadzadeh1999

## 📄 License

This project is available for educational and development purposes.
