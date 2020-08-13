# EmployeesWebApp


## 1. About project
This is a test task project. Created with ASP.NET Core 3.1 and Angular 8.


## 2. Installation Guide

### 2.1 Clone the repository
```bash
git clone https://github.
```

### 2.2 Initialize database
1) Create an empty local MS SQL database and copy its connection string.
2) Go to the project and open **./src/Web/appsettings.Development.json** file. Replace **"Main"** connection string with the one you copied.
3) If you don't have dotnet-ef globally installed then
    ```bash
    dotnet tool install --global dotnet-ef
    ```
4) Run migrations by running **./src/Web/applyMigrations.bat** file.

### 2.3 Run the project
Run the project eather by opening the solution in Visual Studio and running the **Web** project, or by running **./src/Web/run.bat** file.