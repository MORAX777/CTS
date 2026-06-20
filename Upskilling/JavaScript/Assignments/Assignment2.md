# Assignment 2: To-Do List

**Problem Statement**: Create an input field and button. Clicking the button adds the text as a list item.

**Concepts Used**: `createElement`, `appendChild`.

**Solution**:
```html
<!DOCTYPE html>
<html>
<body>
  <input type="text" id="task">
  <button id="addBtn">Add Task</button>
  <ul id="list"></ul>

  <script src="script.js"></script>
</body>
</html>
```
```javascript
// script.js
document.getElementById("addBtn").addEventListener("click", () => {
  let val = document.getElementById("task").value;
  if(val.trim() !== "") {
    let li = document.createElement("li");
    li.innerText = val;
    document.getElementById("list").appendChild(li);
    document.getElementById("task").value = ""; // clear input
  }
});
```

**Expected Output**: New items appear in the bulleted list dynamically.

**Short Explanation**: Using `createElement` generates a new HTML tag in memory, and `appendChild` attaches it to the existing `<ul>` in the DOM.
