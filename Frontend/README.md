# Frontend Internship Test

## Catalog Page

### Todo:
1. **Display Products:**
   - Utilize the `productCategories` list (`Pages/Catalog.razor.cs`) to display each product category.
   - For each category, display individual products using the `Card` component (`Components/Card.razor`).

2. **Update Prices:**
   - Implement functionality to update the price for each card when incremented.
   - Ensure the total price in the footer updates accordingly.

3. **Separate Counter Component:**
   - Create a separate `Counter` component used in the `Card` component.
   - Establish communication between the components to update dynamically.

4. **Styles:**
   - Ensure responsiveness for different screen sizes.

## Card Component

### Todo:
1. **Card Design:**
   - Create a card similar to the one in the provided `AnimatieCard.webm` video.
   - Display Name, Description, Price, (`parameters`) and a counter .
   - If the same product is present multiple times, instead of showing it that many times, show only 1 card with the unique animation from the video(0:06). Needs to work on desktop and tablets.

2. **Dynamic Styling:**
   - Change the background color when `selected` (count > 0).
   - Hide the counter when `count` is 0.
   - Animations.

3. **Counter and Price Update:**
   - Ensure the counter updates dynamically, and the card price adjusts accordingly.

4. **Responsive Design:**
   - Make the card and associated components responsive to different screen sizes.

## Footer

### Todo:
1. **Total Price Display:**
   - Create necessary parameters, services, or methods to correctly display and update the total price.
2. **Responsive Design for Footer:**
   - Ensure the footer is responsive and visually appealing on different screen sizes.



*For styles you can use CSS or Tailwind CSS*

*Add documentation and comments for your code. Try and explain the structure of the components and maybe decisions behind some design choices.*

*You can create or add any file or folder that will be necessary for your implementation to work.*