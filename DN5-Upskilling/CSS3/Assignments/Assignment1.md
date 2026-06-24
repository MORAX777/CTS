# Assignment 1: Center a Div

**Problem Statement**: Horizontally and vertically center a box inside the page.

**Concepts Used**: Flexbox, Viewport Heights (`vh`).

**Solution**:
```html
<!DOCTYPE html>
<html>
<head>
<style>
  body {
    display: flex;
    justify-content: center;
    align-items: center;
    height: 100vh;
    margin: 0;
    background-color: #f0f0f0;
  }
  .box {
    width: 200px;
    height: 200px;
    background-color: coral;
    text-align: center;
    line-height: 200px;
    color: white;
  }
</style>
</head>
<body>
  <div class="box">Centered!</div>
</body>
</html>
```

**Expected Output**: A coral-colored square perfectly centered on the screen.

**Short Explanation**: Setting `height: 100vh` on the body ensures it takes up the full screen height, allowing `align-items: center` to work vertically.
