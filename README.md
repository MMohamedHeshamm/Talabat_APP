# 🛍️ Talabat API
### ASP.NET Core E-Commerce Product Catalog API

![.NET](https://img.shields.io/badge/.NET-10.0-512BD4?logo=dotnet&logoColor=white)
![ASP.NET Core](https://img.shields.io/badge/ASP.NET%20Core-Web%20API-512BD4)
![EF Core](https://img.shields.io/badge/EF%20Core-10-5C2D91)
![SQL Server](https://img.shields.io/badge/Database-SQL%20Server-CC2927)
![Swagger](https://img.shields.io/badge/API%20Docs-Swagger-85EA2D?logo=swagger&logoColor=black)

## 📌 Overview

Talabat API is a backend-focused e-commerce product catalog application developed using **ASP.NET Core 10**, **Entity Framework Core**, and **SQL Server**.

The project demonstrates layered architecture, reusable data access, and RESTful API development using common backend design patterns.

## ✨ Key Features

- Product catalog and product details endpoints
- Product brands and categories
- Generic Repository Pattern
- Specification Pattern
- DTO mapping with AutoMapper
- SQL Server integration using EF Core
- Database migrations and initial data seeding
- Dependency Injection
- Swagger/OpenAPI documentation
- Structured API error responses

## 🏗️ Architecture

The solution separates backend responsibilities across four projects:

| Project | Responsibility |
|---|---|
| `Talbat.APIs` | Controllers, DTOs, mapping, middleware |
| `Talabat.Core` | Entities, interfaces, specifications |
| `Talabat.Repoistry` | EF Core, repositories, database access |
| `Talabat.Service` | Service-layer project for future development |

## 🌐 API Endpoints

| Method | Endpoint | Description |
|---|---|---|
| GET | `/api/Product` | Retrieve all products |
| GET | `/api/Product/{id}` | Retrieve a product by ID |
| GET | `/api/Product/Categories` | Retrieve product categories |
| GET | `/api/Product/Brands` | Retrieve product brands |

## 🚀 Getting Started

**Prerequisites:** .NET 10 SDK, SQL Server or LocalDB, and Git.

Clone the repository:

```bash
git clone https://github.com/MMohamedHeshamm/Talabat_APP.git
cd Talabat_APP
```

Configure `ConnectionStrings:Defo` in `Talbat.APIs/appsettings.json` to point to your SQL Server instance.

Restore and run:

```bash
dotnet restore "Talbat App.slnx"
dotnet run --project Talbat.APIs/Talbat.APIs.csproj
```

The application attempts to apply database migrations and seed initial data at startup.

In the Development environment, open `/swagger` on the local application URL to explore the API.

## 🗺️ Future Enhancements

- [ ] Product sorting, filtering, and pagination
- [ ] Authentication and authorization
- [ ] Shopping basket and order management
- [ ] Payment integration
- [ ] Unit and integration tests
- [ ] Docker and CI/CD support

## 👨‍💻 Author

**Mohamed H. Eldesouky**

Backend Engineer | .NET Developer

[GitHub](https://github.com/MMohamedHeshamm)
