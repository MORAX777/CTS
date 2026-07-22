-- Aryan Kumar Raj - 231fa18066
-- Exercise 2: Index

-- Create a sample table
CREATE TABLE Products (
    ProductID INT PRIMARY KEY,
    ProductName VARCHAR(100),
    Category VARCHAR(50),
    Price DECIMAL(10, 2)
);

-- Create an index on the Category column to optimize search queries
CREATE NONCLUSTERED INDEX IX_Products_Category ON Products(Category);

-- Query that benefits from the index
SELECT ProductName, Price FROM Products WHERE Category = 'Electronics';
