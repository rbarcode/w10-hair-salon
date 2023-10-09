# Eau Claire's Salon

#### By Richard Barbour II

#### C# ASP.NET Core MVC web application that tracks stylists and their clients using MySQL database.

## Technologies Used

* C#
* HTML
* .Net 6.0 SDK (incl. NuGet)
* ASP.NET Core MVC
* MySQL 8.0.34
* Microsoft's Entity Framework Core
* Pomelo.EntityFrameworkCore.MySql (3rd party provider for MySQL compatible databases)

## Description

This web-based application tracks stylists and their clients for a salon owner/manager using a MySQL database and offers CREATE and VIEW functionality for both stylists and clients. The user can navigate between the splash page and pages displaying a list of stylists and a list of clients. The user can also add both stylists and clients, but a client must be assigned to a stylist when the client is created.
 
The web app uses the Entity Framework Core library for object relational mapping (ORM) to manage database interactions with the frontend functionality.

## Setup/Installation Requirements

1. Click on the green “<> Code” on the far right-hand side of the page's main column.
2. On the “Local” tab of the mini-window that opens underneath the “<>Code” button, copy the HTTPS link in the gray bar to your clipboard.
3. In GitBash (or a terminal shell of your choice), navigate to the directory where you wish to download the project and enter the following prompt (replacing the asterisked word with the appropriate link): `git clone *url-of-the-repository-copied-in-the-previous-step*`
4. Your chosen directory will now contain a folder titled "w10-hair-salon".
5. If you don't have the .Net Software Development Kit already installed on your computer, do so now. You may also wish to download the REPL (read-evaluate-print-loop) tool called dotnet-script. You can install the relevant tools introduced in [this series of lessons on LearnHowToProgram.com](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c).
6. If you skipped the previous step and/or don't have MySQL and MySQL Workbench installed, follow the instructions in the LearnHowToProgram.com lesson ["Creating a Test Database: Exporting and Importing Databases with MySQL Workbench"](https://www.learnhowtoprogram.com/c-and-net/database-basics/creating-a-test-database-exporting-and-importing-databases-with-mysql-workbench) to use the `richard_barbour.sql` file located at the top level of this repo (i.e. in the "w10-hair-salon" folder) to create a new database in MySQL Workbench with the same name.
7. Navigate into the production directory "HairSalon" and create a new file called `appsettings.json`.
8. Within `appsettings.json`, put in the following code, replacing the `uid` and `pwd` values (i.e. "[YOUR_USERNAME]" and "[YOUR_PASSWORD]") with your own username and password for MySQL. 

```json
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=richard_barbour;uid=[YOUR_USERNAME];pwd=[YOUR_PASSWORD];"
  }
}
```

9. To build and run the web app on your local server, navigate to the HairSalon directory. In the command line of your terminal, enter the following command to compile and execute the application in a web browser with a watcher: `dotnet watch`. 
10. If you cannot access localhost:5001 it is likely because you have not configured a .NET developer security certificate for HTTPS. To learn about this, review this lesson: [Redirecting to HTTPS and Issuing a Security Certificate](https://www.learnhowtoprogram.com/c-and-net/basic-web-applications/redirecting-to-https-and-issuing-a-security-certificate).

## Known Bugs

No known bugs.

## License

MIT License

Copyright (c) 2023 Richard Barbour II

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.