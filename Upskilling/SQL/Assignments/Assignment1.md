# Assignment 1: Table Creation and CRUD

**Problem Statement**: Create an `Employees` table, insert 3 records, update one, and select all.

**Concepts Used**: DDL, DML.

**Solution**:
```sql
-- schema.sql
CREATE TABLE Employees (
    EmpId INT PRIMARY KEY,
    Name VARCHAR(50),
    Salary DECIMAL(10, 2)
);

-- queries.sql
INSERT INTO Employees (EmpId, Name, Salary) VALUES (1, 'Alice', 50000);
INSERT INTO Employees (EmpId, Name, Salary) VALUES (2, 'Bob', 60000);
INSERT INTO Employees (EmpId, Name, Salary) VALUES (3, 'Charlie', 55000);

-- Give Bob a raise
UPDATE Employees SET Salary = 65000 WHERE EmpId = 2;

SELECT * FROM Employees;
```

**Expected Output**: A table showing Alice, Bob (with 65000), and Charlie.

**Short Explanation**: Simple demonstration of table creation and basic data manipulation.
