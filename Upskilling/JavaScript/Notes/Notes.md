# JavaScript Notes

### Variables
Always use `let` and `const`. Avoid `var` due to hoisting and block-scope issues.
```javascript
const name = "John"; // Can't be reassigned
let age = 20;        // Can be reassigned
```

### Arrow Functions
Shorter syntax. Doesn't bind its own `this`.
```javascript
const greet = (name) => `Hello ${name}`;
```

### DOM Elements
To interact with HTML:
```javascript
let btn = document.getElementById("myBtn");
btn.addEventListener("click", () => alert("Clicked!"));
```

### Common Mistakes
* Confusing `==` (loose equality) with `===` (strict equality). Always use `===`.
* Trying to modify a `const` array entirely (you can push, but can't reassign).

### Interview Tips
* **Q**: What is closure?
  * **A**: A function bundled together with its lexical environment. (A function remembering variables from outside its scope).
* **Q**: Event Bubbling vs Capturing?
  * **A**: Bubbling goes from inner to outer element. Capturing is outer to inner.
