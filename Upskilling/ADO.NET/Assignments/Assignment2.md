# Assignment 2: Parameterized Insert

**Problem Statement**: Safely insert a new record into the database without SQL injection risk.

**Concepts Used**: Parameters, ExecuteNonQuery.

**Solution**:
```csharp
// CRUDExample.cs
using System;
using System.Data.SqlClient;

public class CRUDExample {
    public void InsertUser(string name) {
        string connStr = "Server=localhost;Database=TestDB;Integrated Security=true;";
        using (SqlConnection conn = new SqlConnection(connStr)) {
            conn.Open();
            // Use @Name parameter
            SqlCommand cmd = new SqlCommand("INSERT INTO Users (Name) VALUES (@Name)", conn);
            cmd.Parameters.AddWithValue("@Name", name);
            
            int rows = cmd.ExecuteNonQuery();
            Console.WriteLine($"{rows} row(s) inserted.");
        }
    }
}
```

**Expected Output**: Prints "1 row(s) inserted."

**Short Explanation**: Using `@Name` and `Parameters.AddWithValue` protects against malicious input, treating it strictly as a value, not executable SQL.
