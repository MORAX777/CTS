# Assignment 2: Responsive Photo Grid

**Problem Statement**: Create a 3-column grid that turns into a 1-column grid on mobile.

**Concepts Used**: CSS Grid, Media Queries.

**Solution**:
```html
<!DOCTYPE html>
<html>
<head>
<style>
  .grid-container {
    display: grid;
    grid-template-columns: auto auto auto;
    gap: 10px;
  }
  .grid-item { background: lightblue; padding: 20px; text-align: center; }

  @media (max-width: 600px) {
    .grid-container {
      grid-template-columns: auto;
    }
  }
</style>
</head>
<body>
  <div class="grid-container">
    <div class="grid-item">1</div>
    <div class="grid-item">2</div>
    <div class="grid-item">3</div>
  </div>
</body>
</html>
```

**Expected Output**: 3 columns on desktop, stacking vertically when window is resized below 600px.

**Short Explanation**: `@media (max-width: 600px)` overrides the grid layout when the screen is small.
