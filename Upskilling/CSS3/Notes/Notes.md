# CSS3 Student Notes

### Box Model
Everything is a box.
* **Content** - The actual text/image.
* **Padding** - Space inside the border.
* **Border** - The line around the padding.
* **Margin** - Space outside the border.

*Tip:* Always use `box-sizing: border-box;` so padding doesn't increase total width.

### Flexbox vs Grid
* Use **Flexbox** for 1D layouts (rows OR columns).
* Use **Grid** for 2D layouts (rows AND columns).

```css
.container {
  display: flex;
  justify-content: center; /* horizontal center */
  align-items: center; /* vertical center */
}
```

### Common Mistakes
* Forgetting that `margin` collapses.
* Using `absolute` positioning when `flexbox` would be easier.

### Interview Prep
* **Q**: What's the difference between `display: none` and `visibility: hidden`?
  * **A**: `display: none` removes the element from the document flow. `visibility: hidden` hides it but keeps the empty space.
