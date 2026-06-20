# Assignment 1: OOP Example

**Problem Statement**: Create a class `Car` with properties and a method. Instantiate it in Main.

**Concepts Used**: Classes, Objects, Properties.

**Solution**:
```csharp
// Program.cs
using System;

class Car {
    public string Make { get; set; }
    public string Model { get; set; }

    public void DisplayInfo() {
        Console.WriteLine($"Car: {Make} {Model}");
    }
}

class Program {
    static void Main() {
        Car myCar = new Car { Make = "Toyota", Model = "Camry" };
        myCar.DisplayInfo();
    }
}
```

**Expected Output**: Prints "Car: Toyota Camry" to the console.

**Short Explanation**: Classes act as blueprints. We create an object `myCar` and set its properties using object initializer syntax.
