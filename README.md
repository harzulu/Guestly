# <div align="center">Guestly</div>

<p align="center">
    <br>
    <a href="https://github.com/Harzulu">
        <img src="https://avatars3.githubusercontent.com/u/55816973?s=460&u=46b7375105009121ce5ce53643553fef0ba2be14&v=4" width="150px" height="auto">
    </a>
    <a href="https://github.com/MaxBrockbank">
        <img src="https://avatars.githubusercontent.com/u/48340492?s=460&u=e571605c1709842339fc6510ae69ec0344bb4477&v=4" width="150px" height="auto">
    </a>
    <a href="https://github.com/taylulz">
        <img src="https://avatars.githubusercontent.com/u/61722743?s=460&u=b68a72f8aea84f3239a7efa745ee117631511fa0&v=4" width="150px" height="auto">
    </a>
    <a href="https://github.com/Zahnen">
        <img src="https://avatars.githubusercontent.com/u/30666043?s=460&v=4" width="150px" height="auto">
    </a>
    <a href="https://github.com/kaila-spraguemcrae">
        <img src="https://avatars.githubusercontent.com/u/68969136?s=400&u=9656844bce97d3dc960e4012bcacc5458645885e&v=4" width="150px" height="auto">
    </a>
</p>

<p align="center">
  <small>Last Updated: January 27th, 2021</small>
</p>

# ℹ️ Description
Guestly is a customer relationship management tool designed for the hospitality industry. This app allows hotel staff to manage current guest stays, track revenue performance, and sort through historical guest and reservation data. Guestly makes it easy to create a personalized database for your hotel's portfolio? Queryable database by lifetime revenue, life time nights stayed, yada, and yada. Easy to create Staff roles for employees to use. As an admin, see important historical data in super sick and at-a-glance type graphs.  


## MVP User Stories?
### Have a queryable database of guests with full CRUD funcationality.

~~1. As a hotel employee, I need to be able to see a list of all guests that have stayed at my hotel.~~

~~2. As a hotel employee, I need to be able to see a record of which rooms a guest has stayed in. (I.E. Sarah Johnson stayed in room 207, room 319, and room 500.)~~

~~3. As a hotel employee, I need to be able to track the revenue earned from an individual guest.~~

~~4. As a hotel employee, I need to be able to search/query my list of guests in order to search by revenue earned, most nights stayed, etc.~~

~~5. As a hotel employee, I need to be able to see a details page of each individual guest, where information such as contact info can be viewed.~~

## Stretch Goals?

1. As a hotel employee, I would like to be able to see a details page for hotel rooms and properties (to include a list of guests that have stayed in them).

2. As a hotel employee, I would like if revenue tracking was presented in an easy-to-digest interface (charts, graphs, etc).

3. User Roles - Admin can message application users. [define more roles?] harcode user roles?

~~4. JS front end - adding interactivity with nav bar, etc.~~

~~5. Handle Identity Errors~~

~~6. Sticky search/nav bar~~

~~7. Support links at bottom of page(s) - github link, email link~~

~~8. Sort database with table links~~

9. Add more properties to Guest class, and update seed data

10. Choose what charts and data to display on splash page

11. Add dates to guest visits

12. DEPLOY!

13. exporting database to excel



# 🧑‍💻 Contributers

| Name | GitHub Profile |
|------|----------------|
| [Ben McFarland](https://www.linkedin.com/in/benjamin-mcf/) | [Harzulu](https://github.com/harzulu)|
| [Kaila Sprague McRae](https://www.linkedin.com/in/kaila-sprague-mcrae/) | [kaila-spraguemcrae](https://github.com/kaila-spraguemcrae) |
| [Max Brockbank]() | [MaxBrockbank](https://github.com/MaxBrockbank) |
| [Zahnen Garner]() | [Zahnen](https://github.com/Zahnen) |
| [Taylor Delph](https://www.linkedin.com/in/taylordelph/) | [Taylulz](https://github.com/taylulz) |

# ⚙️ Technologies Used

<details>
  <summary>Expand Tech/tools</summary>

* <a href="https://code.visualstudio.com/">Microsoft Visual Studio Code</a>
* <a href="https://github.com/">Git/GitHub</a>
* <a href="https://docs.microsoft.com/en-us/dotnet/csharp/">C#</a>
* <a href="https://dotnet.microsoft.com/download">.NET Core</a>
* <a href="https://repl.it/languages/csharp">REPL</a>
* <a href="https://docs.microsoft.com/en-us/aspnet/mvc/overview/getting-started/introduction/getting-started">ASP.NET MVC</a>
* <a href="https://developer.mozilla.org/en-US/docs/Learn/CSS">CSS</a>
* <a href="https://getbootstrap.com/">Bootstrap</a>
* <a href="https://docs.microsoft.com/en-us/ef/core/">EF Core</a>
* <a href="https://www.mysql.com/">MySQL/My SQL Workbench</a>

</details>

# 💾 Installation Requirements

## For Both  Mac & Windows systems

* Once you have Git installed on your computer, go to <a href="">this GitHub repository</a>, click the "Fork" button in the upper right hand corner of the page, and clone this application with the following command:
<br> `git clone [GITHUB]`.

## 📁 Installing C#, .NET, dotnet script, & MySQL

### **This program requires C# and the .NET Framework to be installed on your machine:**

## For Mac 
 * Download <a href="https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer">this</a> .NET Core SDK (Software Development Kit). Clicking this link will prompt a .pkg file download from Microsoft.
* Open the .pkg file. This will launch an installer which will walk you through installation steps. Use the default settings the installer suggests.
* Confirm the installation is successful by opening your terminal and running the command `$ dotnet --version`, which should return something like: `2.2.105`. 

## For Windows (10+)

* Download <a href="https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.203-windows-x64-installer">this</a> 64-bit .NET Core SDK (Software Development Kit). Clicking these links will prompt a .exe file download from Microsoft.
* Open the file and follow the steps provided by the installer for your OS.
* Confirm the installation is successful by opening a new Windows PowerShell window and running the command `dotnet --version`. You should see something a response like this: `2.2.105`.

## For Mac & Windows Operating Systems

* Install dotnet script with the following terminal command:
<br> `dotnet tool install -g dotnet-script`.

# 🖥️ Opening the Project on your Local System

* Once the project has been cloned to your computer and you have all the necessary items on your local computer, open the project in the application of your choice (<a href="https://code.visualstudio.com/">Visual Code Studio</a> was used and is recommended by the application builder)

### AppSettings.json File

You will need to create an `appsettings.json` file in the `Guestly` folder. <br>
Once you have the file made, put in this code: <br>
```
{
    "Logging": {
      "LogLevel": {
        "Default": "Warning"
      }
    },
    "AllowedHosts": "*",
    "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=[DATABASE_NAME];uid=root;pwd=[PASSWORD];"
    }
}
```
**Make sure to have a MySQL server up and running on your machine on port 3306** <br>
**Replace `PASSWORD` with the password to your server created for this project**
**Replace `DATABASE_NAME` with the name of your database**

### MySQL Database Setup

* First, using your terminal or command line, navgate to the AnimalShelter folder in AnimalShelter.Solution: `/Guestly.Solution/Guestly`.
* Next, run the command: `dotnet ef database update`.
* You should have your database created for this project.

# ☎️ Support / Contact Details

* [Ben McFarland](mailto:benrmcfarland@gmail.com)
* [Kaila Sprague McRae](kaila.sprague@icloud.com)
* [Max Brockbank](mailto:maxbrockbank1999@gmail.com)
* [Zahnen Garner](mailto:zahnen@gmail.com)
* [Taylor Delph](mailto:taylulzcode@gmail.com)

# 🪲 Bugs / Issues

| Date | Error | Handled | Solution |
| :------------- | :------------- | :------------- | :------------- |
| 01.25.2021 | "The entity type 'IdentityUserLogin<string>' requires a primary key to be defined." | ✅  | add `base.OnModelCreating(builder)` to GuestlyContext.cs |
| 01.25.2021 | "error CS0664: Literal of type double cannot be implicitly converted to type 'float'; use an 'F' suffix to create a literal of this type" | ✅  | add "f" to float data, ie: `125.00f`|
| 01.26.2021 | login, register and create roles do not show errors | ✅  | add `@Html.ValidationSummary(false,"",new { @class = "text-danger"})` to Views and add `ModelState.AddModelError(string.Empty, error.Description)` to Controllers |
| 01.26.2021 | when setting nav bar's position to "fixed" in css, nav covers page contents | ✅  | format through bootstrap by adding "sticky-top" to <nav> class`|
| 01.27.2021 | sorting a table with jQuery is hot garbage | ✅ | add a <span class="data"> to <td> column, modify function to sort by span class instead of td tag |


# ©️ License & Copyright

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

Copyright (c) 2021 *_Ben McFarland, Kaila Sprague McRae, Max Brockbank, Zahnen Garner, Taylor Delph_*
