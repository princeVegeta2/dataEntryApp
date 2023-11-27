using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataEntryAPP
{
    public class DataEntryLogic
    {


        private string connectionString;
        private string tableName;
        private string[] columnsNames;

        public DataEntryLogic(string connectionString, string tableName, string[] columnsNames)
        {
            this.connectionString = connectionString;
            this.tableName = tableName;
            this.columnsNames = columnsNames;
        }

        public void ProcessCsvFile(string csvFilePath, bool skipFirstColumn)
        {
            // List to hold all the data read from the CSV
            List<string[]> allData = new List<string[]>();

            // Read the CSV file using TextFieldParser
            using (TextFieldParser parser = new TextFieldParser(csvFilePath))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                parser.HasFieldsEnclosedInQuotes = true; // If your fields are enclosed in quotes

                while (!parser.EndOfData)
                {
                    // Read fields on the current line
                    string[] fields = parser.ReadFields();

                    // If skipFirstColumn is true, remove the first column
                    if (skipFirstColumn)
                    {
                        fields = fields.Skip(1).ToArray();
                    }

                    allData.Add(fields);
                }
            }

            // Insert the data into the database
            foreach (var dataFields in allData)
            {
                InsertDataIntoDatabase(dataFields);
            }
        }

        private void InsertDataIntoDatabase(string[] dataFields)
        {
            // Construct the SQL INSERT statement using the provided column names and data fields
            StringBuilder queryBuilder = new StringBuilder();
            queryBuilder.Append("INSERT INTO ");
            queryBuilder.Append(tableName);
            queryBuilder.Append(" (");
            queryBuilder.Append(string.Join(", ", columnsNames));
            queryBuilder.Append(") VALUES (");
            queryBuilder.Append(string.Join(", ", dataFields.Select((_, index) => $"@param{index}")));
            queryBuilder.Append(");");

            // Create and open a connection to the SQL server
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Create a command object with the constructed query
                using (SqlCommand command = new SqlCommand(queryBuilder.ToString(), connection))
                {
                    // Add parameters to the command object for each field
                    for (int i = 0; i < dataFields.Length; i++)
                    {
                        command.Parameters.AddWithValue($"@param{i}", dataFields[i]);
                    }

                    // Open the connection and execute the command
                    connection.Open();
                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("The DB table has more columns than specified in the field", "Error", MessageBoxButtons.OK);
                    }
                }
            }
        }
    }
}

