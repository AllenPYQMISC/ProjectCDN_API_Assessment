The ASP.NET project is for demonstration of basic API functionalities which includes:
1. GET
2. POST
3. PUT
4. DELETE

It uses a simple Swagger UI template for displaying the mentioned functionalities and SQL Server LocalDB for data storage.

The SQL Server LocalDB table consists of the following columns:
1. Id		- index, primary key
2. UserName
3. EmailAddress
4. PhoneNumber
5. SkillSets
6. Hobbies

To run the web app,
1. Click on ProjectCDN_API.sln
2. Go to Tools -> NuGet Package Manager -> Package Manager Console
3. In the console, type Add-Migration InitialCreate
4. After Add-Migration has finished, type Update-Database
5. After Update-Database has finished, use Ctrl-F5 to start the web app