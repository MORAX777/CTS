# HTML5 Notes

* HTML handles structure, not styling.
* Use semantic tags to make code readable.

### Important Tags
* `<div>` - block level container (use when no semantic tag fits)
* `<span>` - inline container
* `<header>`, `<footer>`, `<main>`, `<section>`, `<article>` - Semantic tags. Always prefer these over generic divs.

### Forms
```html
<form action="/submit">
  <label for="fname">First name:</label>
  <input type="text" id="fname" name="fname" required>
  <input type="submit" value="Submit">
</form>
```

### Common Mistakes
* Forgetting to close tags.
* Using block elements inside inline elements.
* Not including `alt` attributes in `<img>` tags (bad for accessibility).

### Interview Tips
* **Q**: What's the difference between local storage and session storage?
  * **A**: Local storage has no expiration time. Session storage clears when the tab is closed.
* **Q**: Why use semantic tags?
  * **A**: Better SEO and screen reader support.
