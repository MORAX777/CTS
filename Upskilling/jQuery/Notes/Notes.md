# jQuery Notes

### Basic Syntax
`$(selector).action()`
* `$` sign to define/access jQuery.
* `(selector)` to find HTML elements.
* `action()` to be performed on the element.

### Document Ready
Always wrap code inside ready event to prevent errors if elements aren't loaded yet.
```javascript
$(document).ready(function(){
  // code
});
// Shortcut:
$(function(){
  // code
});
```

### Selectors
* `$("p")` - Tag selector
* `$("#test")` - ID selector
* `$(".test")` - Class selector

### Common Mistakes
* Forgetting to include the jQuery library script tag before using `$`.
* Mixing vanilla JS properties (like `.innerHTML`) with jQuery objects (should use `.html()`).

### Interview Tips
* **Q**: What is the difference between `.html()` and `.text()`?
  * **A**: `.html()` returns content including HTML tags. `.text()` returns only the text.
