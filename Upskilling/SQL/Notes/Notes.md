# SQL Notes

### Core Commands
* **DDL** (Data Definition): `CREATE`, `ALTER`, `DROP`
* **DML** (Data Manipulation): `SELECT`, `INSERT`, `UPDATE`, `DELETE`

### Select Basics
```sql
SELECT * FROM Users WHERE Age > 18;
```

### Joins
Used to combine rows from two tables based on a related column.
* **INNER JOIN**: Returns records with matching values in both tables.
* **LEFT JOIN**: Returns all records from left table, and matched records from right.

### Common Mistakes
* Running an `UPDATE` or `DELETE` without a `WHERE` clause (modifies entire table!).
* Storing sensitive data like passwords as plain text.

### Interview Tips
* **Q**: What is a Primary Key?
  * **A**: A column (or set of columns) that uniquely identifies each row in a table. It cannot be null.
* **Q**: Difference between `DELETE` and `TRUNCATE`?
  * **A**: `DELETE` removes rows one by one and can be rolled back. `TRUNCATE` drops the data page, is faster, and cannot easily be rolled back.
