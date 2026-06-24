# C# Notes

### Object Oriented Programming (OOP)
* **Encapsulation**: Hiding internal state using properties.
* **Inheritance**: Reusing code from a base class (`class Derived : Base`).
* **Polymorphism**: Overriding methods.
* **Abstraction**: Hiding implementation details using interfaces or abstract classes.

### Collections
Use generic collections instead of arrays when size is dynamic.
```csharp
List<string> names = new List<string>();
names.Add("John");
```

### Exception Handling
```csharp
try {
  // risky code
} catch(Exception ex) {
  Console.WriteLine(ex.Message);
} finally {
  // executes regardless of error
}
```

### Common Mistakes
* Forgetting that strings are immutable.
* Not using `using` blocks for disposable objects.

### Interview Tips
* **Q**: Difference between `String` and `StringBuilder`?
  * **A**: String is immutable (creates new object on change). StringBuilder is mutable and much faster for multiple concatenations.
* **Q**: Value type vs Reference type?
  * **A**: Value types (int, struct) are stored on the stack. Reference types (class, string) are stored on the heap.
