# Assignment 1: Student Profile Card

**Problem Statement**: Build a clean student profile card using Bootstrap components.

**Concepts Used**: Bootstrap Cards, Utility classes.

**Solution**:
```html
<!DOCTYPE html>
<html>
<head>
  <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet">
</head>
<body class="bg-light p-5">
  <div class="card shadow" style="width: 18rem;">
    <div class="card-body">
      <h5 class="card-title">Student Name</h5>
      <h6 class="card-subtitle mb-2 text-muted">ID: 12345</h6>
      <p class="card-text">B.Tech IT, 4th Year.</p>
      <a href="#" class="btn btn-primary">View Details</a>
    </div>
  </div>
</body>
</html>
```

**Expected Output**: A styled card with a slight shadow, title, subtitle, and a primary button.

**Short Explanation**: Using the `.card` component saves time compared to writing custom borders and padding.
