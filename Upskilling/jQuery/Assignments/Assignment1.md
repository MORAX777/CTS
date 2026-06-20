# Assignment 1: Hide/Show Text

**Problem Statement**: Add a button to hide a paragraph, and another button to show it.

**Concepts Used**: Event handlers, `hide()`, `show()`.

**Solution**:
```html
<!DOCTYPE html>
<html>
<head>
<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.6.0/jquery.min.js"></script>
</head>
<body>
  <p id="msg">This is a secret message.</p>
  <button id="hideBtn">Hide</button>
  <button id="showBtn">Show</button>

  <script src="script.js"></script>
</body>
</html>
```
```javascript
// script.js
$(document).ready(function(){
  $("#hideBtn").click(function(){
    $("#msg").hide();
  });
  $("#showBtn").click(function(){
    $("#msg").show();
  });
});
```

**Expected Output**: The paragraph disappears when 'Hide' is clicked, and reappears on 'Show'.

**Short Explanation**: Using jQuery makes adding event listeners much shorter than vanilla `document.getElementById`.
