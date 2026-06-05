# PolishDb
## Purpose
This project shows how to map data structures and relationships from C# code into a SQL database using Entity Framework. The main goal is to enforce data integrity between the code and the database, and to demonstrate how Entity Framework works in practice.

## Steps
1. Download or clone repository.
2. Open solution in your .NET IDE.
3. Go to Package Manager Console. Select `PolishDb`(class library project) not `PolishDb.Api` and execute command update-database. This will create SQL database.
4. There are two foreign keys not set on CompaniesTable but they are set on attached dump database manually - this however doesn't matter for queries and relationships.
5. WebApi project is needed for Entity Framework to work correctly and store connection string for the best practice.
