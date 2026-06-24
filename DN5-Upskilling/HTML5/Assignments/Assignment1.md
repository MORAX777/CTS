# Assignment 1: User Registration Form

**Problem Statement**: Create a registration form capturing name, email, password, and gender.

**Concepts Used**: HTML Forms, Input Types, Radio Buttons.

**Solution**:
```html
<!DOCTYPE html>
<html>
<body>
  <h2>Register</h2>
  <form>
    <label>Name: <input type="text" required></label><br><br>
    <label>Email: <input type="email" required></label><br><br>
    <label>Password: <input type="password" required></label><br><br>
    <label>Gender:</label>
    <input type="radio" name="gender" value="m"> Male
    <input type="radio" name="gender" value="f"> Female<br><br>
    <button type="submit">Submit</button>
  </form>
</body>
</html>
```

**Expected Output**: A clean form with basic browser validation.

**Short Explanation**: Used HTML5 input types (`email`, `password`) so the browser handles basic format checking automatically.
