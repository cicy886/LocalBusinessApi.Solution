# Local Business API

#### _An API for a local business lookup. Users can see the list of restaurants and shops in town._

#### By **Sisi Vieira**

## Technologies Used

* _C#_
* _.NET 5.0.100_
* _ASP.NET Core MVC_
* _donet.ef.5.0.10_
* _Microsoft.EntityFrameworkCore 5.0.0_
* _Pomelo.EntityFrameworkCore.MySql 5.0.0-alpha.2_
* _Microsoft.EntityFrameworkCore.Design 5.0.0_
* _.NET 5.0 CLI_
* _Swashbuckle AspNetCore 6.2.3_
* _Git_

## Description

* A user can use endpoints for GET (all and by id), POST, PUT and DELETE.
* A second custom endpoint that accepts parameters - name, category, and rate(example: a SEARCH route that allows users to search by specific business names).
* Model scopes should be used to process parameters from API calls.

Scopes:
- Filters business by name, category, and rate.

Models:
  - Business
    - name - string
    - category - string - only for shops or restaurants
    - description - string
    - rate - interger
    - review - string

* A user can search for random business.
* Using Swagger to documented the endpoints

## Setup/Installation Requirements

### Install C#, .NET, MySQL Community Server and MySQL Workbench
* Open the terminal on your local machine
* If [C#](https://docs.microsoft.com/en-us/dotnet/csharp/) and [.NET](https://docs.microsoft.com/en-us/dotnet/) are not installed on your local device, follow the instructions [here](https://www.learnhowtoprogram.com/c-and-net-part-time-c-and-react-track/getting-started-with-c/installing-c-and-net)
* If [MySQL Community Server](https://dev.mysql.com/downloads/mysql/) and [MySQL Workbench](https://www.mysql.com/products/workbench/) are not installed on your local device, follow the instructions [here](https://www.learnhowtoprogram.com/c-and-net-part-time-c-and-react-track/getting-started-with-c/installing-and-configuring-mysql)
* If [dotnet-ef](https://docs.microsoft.com/en-us/ef/core/cli/dotnet) is not installed on your local device, install it with the terminal command `dotnet tool install --global dotnet-ef --version 5.0.10`

### Clone the project
* Navigate to the directory inside of which you wish to house this project
* Clone this project with the command `$ git clone https://github.com/cicy886/LocalBusinessApi.Solution.git`

### Using Migration
* On your first use of this API, use command `dotnet ef database update` to create the database on your MySQL.
* When a user made changes to the migations: In your terminal, use command `dotnet ef migrations add [Name]` and `dotnet ef database update` after you make any changes to the models and want to update the database.
* When a user wants to delete the old migrations: In your terminal, use command `dotnet ef migrations remove` if you made a mistake with your most recent migraton and you haven't pushed the changes to Github.

### Run the project
* Recreate project environment and install required dependencies with terminal command `$ dotnet restore`.
* Run the program in the console with the command `$ dotnet run`.

### API Endpoints
_Please use Postman or any api platform to run these endpoints_

- Random - GET `http://localhost:5000/api/businesses/random`
  - Returns a random business.
- Search - GET `http://localhost:5000/api/businesses/search?{params}`
  - Returns all businesses with the given search options.
  - Params can be any combination of `name_search={name}&category_search={category}&rate_search={rate}`
  - See below for examples.
- Index(all) - GET `http://localhost:5000/api/businesses`
  - Returns all businesses.
- Create - POST `http://localhost:5000/api/businesses?name={name}&category={category}&description={description}&rate={rate}&review={review}`
  - Creates a new business with the given attributes.
- Show - GET `http://localhost:5000/api/businesses/{id}`
  - Returns an business by its id.
- Update - PUT `http://localhost:5000/api/businesses/{id}?{params}`
  - Updates a given business with the given attributes.
  - Params can be any combination of `name={name}&category={category}&description={description}&rate={rate}&review={review}`
- Destroy - DELETE `http://localhost:5000/api/businesses/{id}`
  -Removes the given business from the data base.

### Using Swagger
* Run the program in the console with the command `$ dotnet run`.
* Open the API using `http://localhost:5000/index.html`
* Swagger has documented all the endponints together, please refer to `API Endpoints` section to use them.

## Known Bugs

* No known bugs.

## License
[MIT](https://opensource.org/licenses/MIT)

Copyright (c) **2021 Sisi Vieira**