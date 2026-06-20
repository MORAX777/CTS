# ADO.NET Notes

### Core Objects
* **SqlConnection**: Establishes link to DB.
* **SqlCommand**: Executes queries (SELECT, INSERT, etc.).
* **SqlDataReader**: Reads data stream (fast, forward-only).
* **SqlDataAdapter**: Fills a DataSet for disconnected architecture.

### Connection String
Usually stored in `appsettings.json` or `App.config`.
`"Server=myServer;Database=myDB;User Id=myUser;Password=myPassword;"`

### Using Statement
Always wrap connections in `using` blocks to ensure they close automatically, even if an error occurs.
```csharp
using (SqlConnection conn = new SqlConnection(connString)) {
   conn.Open();
   // do work
} // conn.Close() happens automatically here
```

### Common Mistakes
* Not closing the connection (leads to connection pool exhaustion).
* String concatenation for queries (leads to SQL Injection). ALWAYS use parameters.

### Interview Tips
* **Q**: ExecuteScalar vs ExecuteNonQuery?
  * **A**: `ExecuteScalar` returns a single value (like from COUNT). `ExecuteNonQuery` returns the number of rows affected (used for INSERT/UPDATE/DELETE).
