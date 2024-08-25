# WebCRUD

WebCRUD is a basic CRUD (Create, Read, Update, Delete) application built with .NET Core and an RDBMS, designed to manage data efficiently through a Web API. This project serves as a foundational example for building RESTful APIs using ASP.NET Core, with a focus on the essential operations for managing records in a relational database.

## Features

- **Create:** Add new records to the database.
- **Read:** Retrieve and display records from the database.
- **Update:** Modify existing records.
- **Delete:** Remove records from the database.
- **Entity Framework Core Integration:** Simplified data access and management using EF Core.
- **API-First Approach:** Designed with a RESTful API architecture for easy integration with front-end applications.
- **Scalable Architecture:** Built with modularity in mind, making it easy to extend and customize.

## Technologies Used

- **.NET Core:** Modern, open-source framework for building cross-platform applications.
- **ASP.NET Core:** Lightweight, high-performance framework for building web applications.
- **Entity Framework Core:** ORM for data access, simplifying database interactions.
- **SQL Server:** Relational Database Management System (RDBMS) used for data storage.

## Getting Started

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) (version 6.0 or later)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) or any other RDBMS of your choice
- [Visual Studio](https://visualstudio.microsoft.com/) or [Visual Studio Code](https://code.visualstudio.com/)

### Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/VandeshSawant/WebCRUD.git
   cd WebCRUD

2. Update the database connection string in appsettings.json:
   ```json
   "ConnectionStrings": {
    "DefaultConnection": "Server=YOUR_SERVER_NAME;Database=YOUR_DATABASE_NAME;User Id=YOUR_USERNAME;Password=YOUR_PASSWORD;"
    }

3. Apply migrations to create the database schema:
   ```bash
   dotnet ef database update

4. Run the application:
   ```bash
   dotnet run
## Usage

### API Endpoints:
- **GET /api/products** - Retrieve all products
- **GET /api/products/{id}** - Retrieve a specific product by ID
- **POST /api/products** - Create a new product
- **PUT /api/products/{id}** - Update an existing product
- **DELETE /api/products/{id}** - Delete a product

## Contributing
Contributions are welcome! Please feel free to submit a pull request or open an issue if you find a bug or have a feature request.

