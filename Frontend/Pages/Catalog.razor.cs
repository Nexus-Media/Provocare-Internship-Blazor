using Frontend.Models;
using Microsoft.AspNetCore.Components;

namespace Frontend.Pages;

public partial class Catalog : ComponentBase
{

    private List<ProductCategory> productCategories = [];
    protected override void OnInitialized()
    {
        // Mock data.
        ProductCategory fruitsCategory = new ProductCategory("Fruits");
        fruitsCategory.AddProduct("Apple", "Sweet and crunchy", 1.99M);
        fruitsCategory.AddProduct("Apple", "Sweet and crunchy", 1.99M, 1);
        fruitsCategory.AddProduct("Apple", "Sweet and crunchy", 1.99M, 1);
        fruitsCategory.AddProduct("Apple", "Sweet and crunchy", 1.99M, 1);
        fruitsCategory.AddProduct("Banana", "Rich in potassium", 0.79M);
        fruitsCategory.AddProduct("Orange", "Citrusy and refreshing", 2.49M);

        ProductCategory vegetablesCategory = new ProductCategory("Vegetables");
        vegetablesCategory.AddProduct("Carrot", "High in vitamin A", 1.29M);
        vegetablesCategory.AddProduct("Broccoli", "Nutrient-rich green vegetable", 2.99M);
        vegetablesCategory.AddProduct("Tomato", "Versatile and juicy", 1.49M);

        ProductCategory dairyCategory = new ProductCategory("Dairy");
        dairyCategory.AddProduct("Milk", "Essential for calcium", 3.49M);
        dairyCategory.AddProduct("Cheese", "Various flavors and types", 4.99M);
        dairyCategory.AddProduct("Yogurt", "Probiotic goodness", 2.79M);
        
        productCategories.Add(fruitsCategory);
        productCategories.Add(vegetablesCategory);
        productCategories.Add(dairyCategory);

        base.OnInitialized();
    }
}