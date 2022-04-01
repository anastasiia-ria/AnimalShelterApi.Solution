# Animal Shelter API

#### Animal Shelter application for the creation of an API using MVC for CRUD

#### By [Anastasiia Riabets](https://github.com/anastasiia-ria)

## Technologies Used

- C#
- .NET 5.0
- ASP.NET Core
- MVC/API architecture

## Description

Animal Shelter lets users to create an API.

## Setup/Installation Requirements

- Clone this repository to your Desktop:
  1. Your computer will need to have GIT installed. If you do not currently have GIT installed, follow [these](https://docs.github.com/en/get-started/quickstart/set-up-git) directions for installing and setting up GIT.
  2. Once GIT is installed, clone this repository by typing following commands in your command line:
     ```
     ~ $ cd Desktop
     ~/Desktop $ git clone https://github.com/anastasiia-ria/AnimalShelterApi.Solution.git
     ~/Desktop $ cd AnimalShelterApi.Solution
     ```
- Install the [.NET 5 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/5.0)
- Create appsettings.json file:
  ```
   ~/Desktop/AnimalShelterApi.Solution $ cd AnimalShelterApi
   ~/Desktop/AnimalShelterApi.Solution/AnimalShelterApi $ touch appsettings.json
   ~/Desktop/AnimalShelterApi.Solution/AnimalShelterApi $ echo '{
      "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=anastasiia_riabets;uid=root;pwd=[PASSWORD];"
      }
    }' > appsettings.json
  ```
  [PASSWORD] is your password
- Install packages and tools:
  ```
  ~/Desktop/AnimalShelterApi.Solution/AnimalShelterApi $ dotnet restore
  ```
- Update Database:
  ```
  ~/Desktop/AnimalShelterApi.Solution/AnimalShelterApi $ dotnet ef database update
  ```
- Build the project:
  ```
   ~/Desktop/AnimalShelterApi.Solution/AnimalShelterApi $ dotnet build
  ```
- Run the project
  ```
   ~/Desktop/AnimalShelterApi.Solution/AnimalShelterApi $ dotnet run
  ```
- Visit [http://localhost:5003](http://localhost:5003) to try this application

## Known Bugs

-

## License

[ISC](https://opensource.org/licenses/ISC)

Copyright (c) 04/01/2022 Anastasiia Riabets
