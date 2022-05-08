# State And National Parks API

#### By _**Chris Nakayama**_

### _May 7, 2022_

#### _An ASP.NET Core web API for U.S. State and National Parks._



## Technologies Used <a id="technologies"></a>

* C#
* .NET 5.0
* ASP.Net Core
* ASP.NET MVC
* Dotnet ef
* Sql
* MySql Workbench
* Visual Studio Code
* Entity Framework Core
* Postman
* Swagger
* Swashbuckle


## Description <a id="descripton"></a>

An ASP.NET Core web API for U.S. State and National Parks. The application is capable of the following:
* Getting a full list of state and national parks or via parameters.
* Getting a state or national park via Id.
* Adding state or national parks to the database.
* Editing a state or national park.
* Deleting a state or national park.

## Setup/Installation Requirements <a id="setup"></a>

1. Make sure you have [MySql Workbench](https://www.mysql.com/products/workbench/) installed.
2. Make sure to have dotnet-ef installed too.<br>
This project uses <code>dotnet-ef --version 5.0.0</code> which I have globally installed but you can install it however you want. 
3. Download .NET 5.0 SDK for : <a href="https://dotnet.microsoft.com/download/dotnet/thank-you/sdk-5.0.102-windows-x64-installer" target="_blank">Windows</a> or <a href="https://dotnet.microsoft.com/download/dotnet/thank-you/sdk-5.0.100-macos-x64-installer" target="_blank">Mac</a>.

4. Clone the appliction to your computer by entering: ```git clone https://github.com/ChrisNakayama/Parks.Solution``` in the terminal.
5. Open the repository in the terminal and cd into the ```Parks``` directory.
6. Create a new file by entering `touch appsettings.json`  in the root directory
7. Enter the following code below. Be sure to replace [Password] with the password for MySql workbench that you have set up. Do the same for [userid], the uid is the user id you've set up in MySql workbench.
```
{
  "Logging": {
    "LogLevel": {
      "Default": "Warning",
      "System": "Information",
      "Microsoft": "Information"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=parks_api;uid=root;pwd=[YOUR-PASSWORD-HERE];"
  }
}
```
8. Run ```dotnet build``` on the command line to check for errors.
9. Launch MySql Workbench 
10. Back in the terminal, run ```dotnet ef migrations add Initial```. <em>Note:</em> when making changes to the schema (i.e. making changes in the models that affect the database such as adding a new attribute, you would change "Initial" to something more descriptive of what change you are making to the table.
11. Next run ```dotnet ef database update``` to update the table. I've included values in the StateAndNatParkContext.cs file to seed the database with some state and national park entries for testing.
12. Run ```dotnet build``` again to ensure there are no errors.
13. Once everything builds successfully, enter ```dotnet run``` on the command line to start the StateAndNatParks API.

## API Info/Endpoints <a id="api"></a>
* Once the API is running, you can test the API endpoints on the index page: https://localhost:5001/index.html using Swagger.

The API endpoints are the following:
```
- GET /api/StateAndNatParks (returns a list of the state and national parks)
- POST /api/StateAndNatParks (allows user to add new park to the database)
- GET /api/StateAndNatParks/{id} (list an park by a specific id)
- PUT /api/StateAndNatParks/{id} (edit information about a specific park)
- DELETE /api/StateAndNatParks/{id} (delete a specific park by id)
```
Hit this link in Swagger to try out this API:
https://localhost:5001/swagger/index.html



## Known Bugs <a id="bugs"></a>

* _No known issues_

## License <a id="license"></a>

[MIT License](https://opensource.org/licenses/MIT) Published _**2022**_ by _**Chris Nakayama**_

## Contact Information <a id="contact"></a>

If you encounter any issues or have any questions or ideas for this site, please contact:

Chris Nakayama:
* Email: [cnakayam@gmail.com](mailto:cnakayam@gmail.com)
* Github: [ChrisNakayama](https://github.com/ChrisNakayama)

