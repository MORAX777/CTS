# Assignment 2: Using Joins

**Problem Statement**: Retrieve Employee Names along with their Department Names.

**Concepts Used**: INNER JOIN.

**Solution**:
```sql
-- schema.sql
CREATE TABLE Departments (
    DeptId INT PRIMARY KEY,
    DeptName VARCHAR(50)
);

CREATE TABLE Employees (
    EmpId INT PRIMARY KEY,
    Name VARCHAR(50),
    DeptId INT FOREIGN KEY REFERENCES Departments(DeptId)
);

-- queries.sql
INSERT INTO Departments VALUES (1, 'IT'), (2, 'HR');
INSERT INTO Employees VALUES (1, 'Alice', 1), (2, 'Bob', 2);

-- Query
SELECT Employees.Name, Departments.DeptName 
FROM Employees
INNER JOIN Departments ON Employees.DeptId = Departments.DeptId;
```

**Expected Output**: 
Alice | IT
Bob   | HR

**Short Explanation**: The foreign key `DeptId` links the two tables, allowing us to fetch the readable department name instead of just the ID.
