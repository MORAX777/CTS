# Assignment 2: Fade Toggle

**Problem Statement**: Use a single button to toggle the visibility of an element with a fade effect.

**Concepts Used**: `fadeToggle()`.

**Solution**:
```html
<!DOCTYPE html>
<html>
<head>
<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.6.0/jquery.min.js"></script>
<style>
  #box { width: 100px; height: 100px; background: red; }
</style>
</head>
<body>
  <button id="toggleBtn">Toggle Fade</button>
  <br><br>
  <div id="box"></div>

  <script src="script.js"></script>
</body>
</html>
```
```javascript
// script.js
$(document).ready(function(){
  $("#toggleBtn").click(function(){
    $("#box").fadeToggle("slow");
  });
});
```

**Expected Output**: The red box slowly fades out and fades in when the button is clicked.

**Short Explanation**: `fadeToggle` automatically checks if the element is visible or hidden and performs the opposite fade action.
