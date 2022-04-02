# Animal Shelter API

#### Animal Shelter application for the creation of an API using MVC for CRUD

#### By [Anastasiia Riabets](https://github.com/anastasiia-ria)

## Technologies Used

- C#
- .NET 5.0
- ASP.NET Core
- MVC/API architecture
- Pagination
- Versioning

## Description

Animal Shelter lets users create an API.

## Setup/Installation Requirements

- Clone this repository to your Desktop:
  1. Your computer will need to have GIT installed. If you do not currently have GIT installed, follow [these](https://docs.github.com/en/get-started/quickstart/set-up-git) directions for installing and setting up GIT.
  2. Once GIT is installed, clone this repository by typing following commands in your command line:
     <pre>
     ~ $ cd Desktop
     ~/Desktop $ git clone https://github.com/anastasiia-ria/AnimalShelterApi.Solution.git
     ~/Desktop $ cd AnimalShelterApi.Solution
  </pre>
- Install the [.NET 5 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/5.0)
- Create appsettings.json file:
  <pre>
   ~/Desktop/AnimalShelterApi.Solution $ cd AnimalShelterApi
   ~/Desktop/AnimalShelterApi.Solution/AnimalShelterApi $ touch appsettings.json
   ~/Desktop/AnimalShelterApi.Solution/AnimalShelterApi $ echo '{
      "Logging": {
        "LogLevel": {
          "Default": "Warning",
          "System": "Information",
          "Microsoft": "Information"
        }
      },
      "AllowedHosts": "*",
      "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=anastasiia_riabets;uid=root;pwd=[PASSWORD];"
      }
    }' > appsettings.json
  </pre>
  [PASSWORD] is your password
- Install packages and tools:
  <pre>
  ~/Desktop/AnimalShelterApi.Solution/AnimalShelterApi $ dotnet restore
  </pre>
- Update Database:
  <pre>
  ~/Desktop/AnimalShelterApi.Solution/AnimalShelterApi $ dotnet ef database update
  </pre>
- Build the project:
  <pre>
   ~/Desktop/AnimalShelterApi.Solution/AnimalShelterApi $ dotnet build
  </pre>
- Run the project
  <pre>
   ~/Desktop/AnimalShelterApi.Solution/AnimalShelterApi $ dotnet run
  </pre>
- Access you API by following this link: [http://localhost:5004/api/animals](http://localhost:5004/api/animals) to try this application

## Endpoints

| Endpoints                | Returns                        |
| ------------------------ | ------------------------------ |
| api/animals              | All animals                    |
| api/animals/1            | An animal with id = 1          |
| api/animals/random       | Random animal                  |
| api/animals?species=dog  | Animals filtered by species    |
| api/animals?sex=male     | Animals filtered by sex        |
| api/animals?color=black  | Animals filtered by color      |
| api/animals?breed=hound  | Animals filtered by breed      |
| api/animals?pageNumber=2 | Second page of all animals     |
| api/animals?pageSize=50  | One page contains max 50 items |

## Versioning

- To change default version of the API, replace highlighted code in Startup.cs with desired version:
  <pre>
  ...
  services.AddApiVersioning(o =>
      {
        o.ReportApiVersions = true;
        o.AssumeDefaultVersionWhenUnspecified = true;
        o.DefaultApiVersion = new ApiVersion<b><span style="color:red">(1, 0)</span></b>;
      });
  ...
  </pre>
- To add another version of API, add this class in AnimalsController.cs:
  <pre>
  ...
  [ApiVersion("2.0")]
  [Route("api/{m:apiVersion}/animals")]
  public class ValuesV2Controller : ControllerBase
  {
    // Code
  }
  ...
  </pre>
- To deprecate previous versions, add "Deprecated = true" for that version's class:
  <pre>
  ...
  [ApiVersion("1.0", <b><span style="color:red">Deprecated = true</span></b>)]
  [Route("api/animals")]
  public class ValuesV2Controller : ControllerBase
  {
    // Code
  }
  ...
  </pre>

## Pagination

- To change default values for pagination, go to Filter/PaginationFilter.cs and update highlighted values:
  <pre>
  ...
  public PaginationFilter()
    {
      this.PageNumber = <b><span style="color:red">1</span></b>;
      this.PageSize = <b><span style="color:red">100</span></b>;
    }
    public PaginationFilter(int pageNumber, int pageSize)
    {
      this.PageNumber = pageNumber < <b><span style="color:red">1</span></b> ? <b><span style="color:red">1</span></b> : pageNumber;
      this.PageSize = pageSize > <b><span style="color:red">100</span></b> ? <b><span style="color:red">100</span></b> : pageSize;
    }
  ...
  </pre>

## Known Bugs

-

## License

[ISC](https://opensource.org/licenses/ISC)

Copyright (c) 04/01/2022 Anastasiia Riabets
