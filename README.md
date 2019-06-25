# Index.txt
A web based todo.txt list

## Setup
### Clone the repo
run these commands to get started
```
git clone https://github.com/YOUR-WORST-TACO/index.txt.git
cd index.txt
dotnet restore
```

### Connection String
change <b>Server</b>, <b>User Id</b>, <b>Password</b> and <b>Database</b> to match your current setup. Note by default
we are using MariaDB.
```json
// appsettings.json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost; User Id=root;Password=Password123;Database=indexTxtDb"
  },
  ...
}
```
### DB Migrations
run the following commands to perform a migration to setup the tables for our database
```
dotnet ef migrations add InitialDbSetup
```
and then apply the migration
```
dotnet ef database update
```
### Running
once everything has setup and god has been merciful, run the following to start the server
```
dotnet run
```