# Assignment 1: Basic Calculator

**Problem Statement**: Write a script to add two numbers from input fields and display the result.

**Concepts Used**: DOM selection, Event Listeners, `parseInt`.

**Solution**:
```html
<!DOCTYPE html>
<html>
<body>
  <input type="number" id="num1"> + 
  <input type="number" id="num2">
  <button id="calc">Calculate</button>
  <p>Result: <span id="res"></span></p>

  <script src="script.js"></script>
</body>
</html>
```
```javascript
// script.js
document.getElementById("calc").addEventListener("click", function() {
  let a = parseInt(document.getElementById("num1").value);
  let b = parseInt(document.getElementById("num2").value);
  if(!isNaN(a) && !isNaN(b)) {
    document.getElementById("res").innerText = a + b;
  } else {
    document.getElementById("res").innerText = "Invalid Input";
  }
});
```

**Expected Output**: Typing numbers and clicking 'Calculate' updates the result paragraph.

**Short Explanation**: We extract values from the inputs, parse them to integers, add them, and update the text content of the span.
