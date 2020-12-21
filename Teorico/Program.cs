//Responsibility of each MVC part:
// Model: domain entities structure and their transformations (domain model)
//o Entities
//o Services (related to entities)
// Repositories(persistent data access)
// Controllers: receives user interactions and treat them
// Views: defines structure and behaviour of user interface

//Checklist:
// wwwroot: application resources(css, imagens, etc.)
// Controllers: application's MVC controllers
// Models: entities and "view models"
// Views: pages(notice naming conventions against controllers)
//o Shared: views used for more than one controller
// appsettings.json: external resources configuration (logging, connection strings, etc.)
// Program.cs: entry point
// Startup.cs: app configuration
//First controller and Razor pages tests

//Checklist:
// Route pattern: Controller / Ação / Id
//o Each controller method is mapped to an action
// Natural Templates
// C# block in Razor Page: @{ }
// ViewData dictionary
// Tag Helpers in Razor Pages. Examples: asp - controller and asp-action
// IActionResult

//First Model-Controller-View - Department
//Checklist:
// Create new folder ViewModels e move ErrorViewModel (including namespace)
//o CTRL+SHIFT+B to fix references
// Create class Models/Department
// Create controller: right button Controllers -> Add -> Controller -> MVC Controller Empty
//o Name: DepartmentsController(PLURAL)
//o Instantiate a List<Department> and return it as View method parameter
// Create new folder Views/Departments(PLURAL)
// Create view: right button Views/Departments -> Add -> View
//o View name: Index
//o Template: List
//o Model class: Department
//o Change Title to Departments
//o Notice:
// @model definition
// intellisense for model
// Helper methods
// @foreach block
//Deleting Department view and controller
//Checklist:
// Delete controller
// Delete folder Views/Departments
//CRUD Scaffolding

//Checklist:
// Right button Controllers -> Add -> New Scaffolded Item
//o MVC controllers with views, using Entity Framework
//o Model class: Department
//o Data context class: + and accept the name
//o Views (options): all three
//o Controller name: DepartmentsController
//MySQL adaptation and first migration
//Note: we're using CODE-FIRST workflow

//Checklist:
// Em appsettings.json, set connection string:
//o "server=localhost;userid=developer;password=1234567;database=saleswebmvcappdb"
// Em Startup.cs, fix DbContext definition for dependency injection system:
//services.AddDbContext<SalesWebMvcAppContext>(options =>
// options.UseMySql(Configuration.GetConnectionString("SalesWebMvcContext"), builder =>
//builder.MigrationsAssembly("SalesWebMvc")));

// Install MySQL provider:
//o Open NuGet Package Manager Console
//o Install-Package Pomelo.EntityFrameworkCore.MySql
// Stop IIS
// CTRL+SHIFT+B
// Start MySQL server:
//o Control Panel -> Administrative Tools -> Services
// Start MySQL Workbench
// Package Manager Console -> create first Migration:
//o Add-Migration Initial
//o Update-Database
// Check database in MySQL Workbench
// Test app: CTRL+F5

//Changing theme
//Checklist:
// Go to: http://bootswatch.com/3 (check Bootstrap version)
// Choose a theme
// Download bootstrap.css
//o Suggestion: rename to bootstrap-name.css
//o Save file to wwwroot/lib/bootstrap/dist/css (paste it inside Visual Studio)
// Open _Layout.cshtml
//o Update bootstrap reference






using System;

namespace Teorico
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
