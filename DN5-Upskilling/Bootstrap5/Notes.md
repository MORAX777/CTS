# Bootstrap5 Notes

### Container
Use `.container` for a responsive fixed width.
Use `.container-fluid` for full width.

### Grid
The grid has 12 columns.
* Small screens: `.col-sm-*`
* Medium screens: `.col-md-*`
* Large screens: `.col-lg-*`

### Utilities
Instead of writing CSS, use:
* `.m-3` (margin)
* `.p-2` (padding)
* `.bg-primary` (background color)
* `.text-center` (alignment)

### Common Mistakes
* Nesting `.container` inside another `.container`. (Always use `.row` inside `.container`).
* Forgetting the viewport meta tag in the HTML head.

### Interview Tips
* **Q**: What are the main breakpoints?
  * **A**: sm (576px), md (768px), lg (992px), xl (1200px), xxl (1400px).
