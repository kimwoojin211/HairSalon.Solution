# _Eau Claire's Salon_

## _This project is not in a complete or portfolio ready state, and should not be considered representational of professional work._

#### _Program that utilizes databases to help manage hair stylists and their clients_

#### By _**Woo Jin Kim**_

## Technologies Used

* _C#_
* _.NET 5.0.102_
* _ASP.NET Core Mvc 4.8_
* _Razor_
* _Entity Framework Core_
* _MySql_
* _Git_

## Description

_Program that allows a salon owner to:_

* See a list of all stylists
* Select a stylist, see their details, and see a list of all clients that belong to that stylist.
* Add new stylists to the system when they are hired.
* Add new clients to a specific stylist. (Clients cannot be added if no stylists added.)

## Setup/Installation Requirements
<br>

### Application Setup
<details>
<summary>Hide/Show Instructions</summary>

_Note: Make sure you have **.NET 5.0** installed. If not, please visit [this link](https://dotnet.microsoft.com/download/dotnet/5.0)_

* _Clone this repository to your computer from [this repository](https://github.com/kimwoojin211/HairSalon.Solution.git)
* _In your terminal of choice, navigate to the HairSalon directory_
* _Create a file named "appsettings.json" in this directory_
* _Add the following lines of code to your newly created "appsettings.json" file and save._
```
{
"ConnectionStrings": {
"DefaultConnection": "Server=localhost;Port=3306;database=[YOUR DATABASE];uid=root;pwd=[YOUR PASSWORD];"
}
}
```
**NOTE:** _[YOUR DATABASE]_ and _[YOUR PASSWORD]_ **MUST** be the same database name and password as those of your local MySql server. Please see **Database Setup** for more details.
</details>
<br>

### Database Setup 

<details>
<summary>Hide/Show Instructions</summary>

* _If not already installed, please download MySql Workbench [here](https://www.mysql.com/products/workbench/)
  and follow the installation/setup instructions listed [here](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql)_
* _Open MySql Workbench and select a local server_
* _In the Navigtor section, click the Administration tab, and click on Data Import/Restore_
* _Under Import Options, select Import from Self-Contained File, and select "woojin_kim.sql", found in the HairSalon.Solutions directory to import the database structure_
* _Under Default Schema to be Imported To, select the New button_
* _Enter a name for your database and hit Ok_
* _Click Start Import_
</details>
<br>

### Once all of the steps above are completed

<details>
<summary>Hide/Show Instructions</summary>

* _Navigate back to the HairSalon.Solution directory on your terminal_
* _Navigate into the HairSalon directory_
* _Enter `dotnet build` into the terminal_
* _Enter `dotnet run` into the terminal_
</details>
<br>

## Known Bugs

* N/A
## License

_MIT_

## Contact Information

_Woo Jin Kim (kimwoojin211@gmail.com)_
Copyright (c) 2021 Woo Jin Kim