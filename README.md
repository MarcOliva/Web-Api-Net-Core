# Web-Api-Net-Core
Final Project Web Api using .Net Core

If you want this project, follow the next steps:
 1. Delete Migrations folder if exist.
 2. Type in a shell , the next command:
    dotnet ef --startup-project ../Faro.Api migrations add init
 3.Create a database called "Faro".
 4.Update the database and create database tables,type in the project's terminal:
    dotnet ef --startup-project ../Faro.Api database update
