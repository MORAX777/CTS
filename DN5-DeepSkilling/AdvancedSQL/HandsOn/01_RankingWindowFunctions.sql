-- Aryan Kumar Raj - 231fa18066
-- Exercise 1: Ranking and Window Functions

CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY,
    Name VARCHAR(100),
    Department VARCHAR(50),
    Salary DECIMAL(10, 2)
);

INSERT INTO Employees (EmployeeID, Name, Department, Salary) VALUES
(1, 'Alice', 'IT', 75000),
(2, 'Bob', 'HR', 55000),
(3, 'Charlie', 'IT', 80000),
(4, 'David', 'Finance', 90000),
(5, 'Eve', 'HR', 60000);

-- Query using RANK and DENSE_RANK window functions
SELECT 
    Name, 
    Department, 
    Salary,
    RANK() OVER (PARTITION BY Department ORDER BY Salary DESC) AS DeptRank,
    DENSE_RANK() OVER (ORDER BY Salary DESC) AS OverallDenseRank
FROM 
    Employees;
