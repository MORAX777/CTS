-- Aryan Kumar Raj - 231fa18066
-- Exercise: Return Data from a Scalar Function

-- Create a scalar function to calculate annual bonus
CREATE FUNCTION CalculateBonus
(
    @Salary DECIMAL(10, 2),
    @BonusPercentage DECIMAL(5, 2)
)
RETURNS DECIMAL(10, 2)
AS
BEGIN
    DECLARE @BonusAmount DECIMAL(10, 2);
    SET @BonusAmount = @Salary * (@BonusPercentage / 100);
    RETURN @BonusAmount;
END;
GO

-- Execute the scalar function
SELECT 
    Name, 
    Salary, 
    dbo.CalculateBonus(Salary, 10.0) AS AnnualBonus
FROM 
    Employees;
