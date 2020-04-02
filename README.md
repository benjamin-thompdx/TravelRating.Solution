# _Travel Rating API_

#### By _**Benjamin Thom, Steph Podolak, Matt Taylor, & K. Wicz**_


## Description

_An ASP.NET API that allows users to read and write reviews about travel destinations around the world, categorized by city and country._


## API Endpoints

### Locations

Retrieve a list of travel destinations around the world.

#### HTTP Request
```sh
GET https://localhost:5000/locations
```
#### Path Parameters
| Parameter | Type | Default | Description |
| :---: | :---: | :---: | --- |
| name | string | none | Returns matches by destination name.
| city | string | none | Returns all destinations in specified city. |
| country | string | none | Returns all destinations in specified country. |

#### Example Query
```sh
https://localhost:5000/api/locations/?name=ha+long+bay&city=hanoi&country=vietnam
```

### Experiences

#### Path Parameters
| Parameter | Type | Default | Description |
| :---: | :---: | :---: | --- |
|Author | string | none | Returns all experiences made by review author. |
|Review | string | none | Returns experience by exact review given. |
|Rating | int | none | Returns all experiences with a specific rating value between 1 and 5|

#### Example Query
```sh
https://localhost:5000/api/experiences/?author=ben&review=hanoi+is+quite+a+beaut!&rating=5
```

## Setup/Installation Requirements

### 1.  Install .NET Core

#### on macOS:
* [Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer) to download a .NET Core SDK from Microsoft Corp.

#### on Windows:
* [Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.203-windows-x64-installer) to download the 64-bit .NET Core SDK from Microsoft Corp.

#### Install dotnet script
Enter the command ``dotnet tool install -g dotnet-script`` in Terminal (macOS) or PowerShell (Windows).

### 2. Clone this repository

Enter the following commands in Terminal (macOS) or PowerShell (Windows):
```sh
cd desktop
git clone https://github.com/kwicz/TravelRating.Solution
cd TravelRating.Solution
```
### 3. Install all necessary packages and make sure the project will build
In your terminal, type the following commands to make sure all necessary packages are included in the project and to launch in your browser:
```sh
cd TravelRating
dotnet restore
dotnet build
```

### 4. Create the database and tables
Enter the following to build your database and tables for the program:
```sh
dotnet ef migrations add Initial
dotnet ef database update
```

### 5. Launch the project in your browser
In your terminal, type:
```sh
dotnet watch run
```
Hold ```command``` while clicking the link in your local terminal to your local address, which should be:
```sh
http://127.0.0.1:5000
```

## Known Bugs

_No known bugs at this time._

## Support and contact details

_Have a bug or an issue with this application? [Open a new issue](https://github.com/kwicz/TravelRating.Solution/issues) here on GitHub._

## Technologies Used
* _C#_
* _.NET Core 2.2_
* _ASP.NET Core MVC_
* _MySQL 2.2.0_
* _EF Core 2.2.0_
* _ASP.NET Core Identity_
* _Razor 2.2.0_
* _ASP.NET Core JSON Web Token Authentication & Authorization_
* _NSwag 13.3.0_
* _[Postman](postman.com)_

## License

[MIT](https://choosealicense.com/licenses/mit/)

Copyright (c) 2020 **_K Wicz, Benjamin Thom, Matt Taylor, Steph Podolak_**