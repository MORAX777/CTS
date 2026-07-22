-- Aryan Kumar Raj - 231fa18066
-- Exercise: Create, Return Data, and Execute a Stored Procedure

-- Create procedure to get employee by department
CREATE PROCEDURE GetEmployeesByDepartment
    @DeptName VARCHAR(50),
    @EmployeeCount INT OUTPUT
AS
BEGIN
    -- Return data
    SELECT EmployeeID, Name, Salary 
    FROM Employees 
    WHERE Department = @DeptName;

    -- Set output variable
    SELECT @EmployeeCount = COUNT(*) 
    FROM Employees 
    WHERE Department = @DeptName;
END;
GO

-- Execute the stored procedure
DECLARE @TotalCount INT;
EXEC GetEmployeesByDepartment @DeptName = 'IT', @EmployeeCount = @TotalCount OUTPUT;

PRINT 'Total Employees in IT: ' + CAST(@TotalCount AS VARCHAR);
