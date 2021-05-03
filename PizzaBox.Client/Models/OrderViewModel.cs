using System.Collections.Generic;

namespace PizzaBox.Client.Models
{
  public class OrderViewModel
  {
    public List<string> Crusts { get; set; } = new List<string> { "Thin", "Original", "Brooklyn", "Deep Dish", "Stuffed" };
    public List<string> Sizes { get; set; } = new List<string> { "Small", "Medium", "Large", "X-Large" };
    public List<string> Toopings { get; set; }

    public string SelectedCrust { get; set; }
    public string SelectedSize { get; set; }
    public List<string> SelectedToppings { get; set; }
  }
}
