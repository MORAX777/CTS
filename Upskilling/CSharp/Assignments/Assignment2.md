# Assignment 2: Exception Handling

**Problem Statement**: Write a program that divides two numbers and handles divide-by-zero errors.

**Concepts Used**: try-catch blocks.

**Solution**:
```csharp
// Program.cs
using System;

class Program {
    static void Main() {
        int a = 10;
        int b = 0;
        
        try {
            int result = a / b;
            Console.WriteLine(result);
        }
        catch (DivideByZeroException ex) {
            Console.WriteLine("Error: Cannot divide by zero.");
        }
    }
}
```

**Expected Output**: Prints "Error: Cannot divide by zero."

**Short Explanation**: Without the try-catch block, dividing by zero would crash the application. Catching the specific exception allows safe failure.
