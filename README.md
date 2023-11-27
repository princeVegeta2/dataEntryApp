# Automatic data entry app
This simple Windows Forms app is designed to simplify the process of inserting data into your database tables.

## Prerequisites
- Microsoft.VisualBasic.FileIO.TextFieldParser (NuGet)
- System.Data.SqlClient (NuGet)
- .NET 

## Functionality
The application takes the user's Connection String, Table name and ALL of the columns in that table and assigns to them values found in a selected .CSV file

## Launch
- Launch the .SLN file if you want to run the source code in debug mode and see how it works
**OR**
- Navigate to `\DataEntryAPP\DataEntryAPP\bin\Release\net6.0-windows` and launch the 'DataEntryAPP.exe' to use the Release version

## Usage
- Launch the application
- Enter the connection in the first field or simply change the values of a default one
- Enter the table name of your database which you want to change
- Enter the column names separated by a comma
- Check the box if you want to skip the first column of the **CSV** file. This might be useful if you exported a table from a database and it contains an ID column which you might not want to include.
- Click the **Process** button to launch the process
- Check your database's table to see the changes

## Note
You may use/change this app however you want or submit a pull request if you want to implement new functionality. 