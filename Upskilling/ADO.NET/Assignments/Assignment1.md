# Assignment 1: Connect and Read

**Problem Statement**: Connect to a database and read names from a `Users` table.

**Concepts Used**: SqlConnection, SqlCommand, SqlDataReader.

**Solution**:
```csharp
// Program.cs
using System;
using System.Data.SqlClient;

class Program {
    static void Main() {
        string connStr = "Server=localhost;Database=TestDB;Integrated Security=true;";
        using (SqlConnection conn = new SqlConnection(connStr)) {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT Name FROM Users", conn);
            
            using (SqlDataReader reader = cmd.ExecuteReader()) {
                while(reader.Read()) {
                    Console.WriteLine(reader["Name"].ToString());
                }
            }
        }
    }
}
```

**Expected Output**: Prints the list of names from the database to the console.

**Short Explanation**: `SqlDataReader` iterates through the result set row by row. It's the fastest way to read data.
