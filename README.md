# Library Manegement System

**This is a library management system designed using Microsoft SQL Server and implemented using C# WinForms and the .NET Framework. The purpose of this project is to provide a reliable and efficient system for managing a library's data, including book information, member information, membership, loaning and returning books, fines, payments.**

## Features
- Easy-to-use graphical interface for manipulating the data in the database
- Insert, view and update data of books, members, memberships loans, returns, fines, payments,... easily from the application
- Generate statistics reports for different aspects of the library's operation with the useage of graphs and charts.
- Automatically calculate different types of fine based on return dates and return status and track payments made by members

## Technologies Used
- Microsoft SQL Server for designing the relational database
- C# WinForms for implementing the graphical user interface
- .NET Framework for providing a framework for building Windows applications
- Visual Studio IDE for developing and testing the application and designing the GUI
- Entity Framework for object-relational mapping of the database

## Installation
- Clone or download this repository to your local machine
- There is a backup file of the database named "LMS1.bak" with all the objects of the database and sample data, you can install this file to your local server of SQL Server.
- Or you can Open Microsoft SQL Server and execute the sql file LMS_SQL_script.sql, this will create a new database named "LMS1" on your server on Microsoft SQL Server that includes all the objects required for the database but no sample data.
- Open the solution file Form_LMS.sln in Visual Studio
- Edit the ConStr in the file ConnectionString.cs to match the properties of the server and the LMS1 database you just created on your Microsoft SQL Server. The following is the file ConnectionString.cs in the solution file:
```c#
namespace Form_LMS
{
internal class ConnectionString
	{
		public static string ConStr = @"Data Source = HNVvv; Initial Catalog = LMS1; Integrated Security = True; TrustServerCertificate = True";
	}
}
```
You will need to replace the former server name with your server name and add your user name and password if your server is using SQL Server authentication, for example:
```c#
public static string ConStr = @"Data Source = YourServerName; Initial Catalog = LMS1; User ID = YourUsername; Password = YourPassword; TrustServerCertificate = True";
```
- Build the solution to compile the code
- Run the application by pressing F5 or clicking the "Start" button in Visual Studio toolbar

## Usage
- Upon launching the application, you can use the various buttons and menus to navigate the application and manage the library's data.

## Demonstration
- The features and funtions of the application are shown in this video [Demo video](https://husteduvn-my.sharepoint.com/:v:/g/personal/vu_hn215171_sis_hust_edu_vn/ESTWX9iAKztNupuUtteBQ58BaakrJwl1AYZCfxDFeca2kQ?e=To2JoI)

## Contributors
- **Hoang Nguyen Vu** - initial work
