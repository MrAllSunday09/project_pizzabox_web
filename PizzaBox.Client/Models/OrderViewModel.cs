using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using PizzaBox.Domain.Models;
using PizzaBox.Storing;

namespace PizzaBox.Client.Models
{
  public class OrderViewModel : IValidatableObject
  {
    public List<Crust> Crusts { get; set; }
    public List<Size> Sizes { get; set; }
    public List<Topping> Toppings { get; set; }

    [Required(ErrorMessage = "Select Crust")]
    [DataType(DataType.Text)]
    public string SelectedCrust { get; set; }

    [Required(ErrorMessage = "Select Size")]
    [DataType(DataType.Text)]
    public string SelectedSize { get; set; }

    [Required(ErrorMessage = "Select Toppings")]
    public List<string> SelectedToppings { get; set; }

    public OrderViewModel()
    {

    }
    public OrderViewModel(UnitOfWork unitOfWork)
    {
      Crusts = unitOfWork.Crusts.Create().ToList();
      Sizes = unitOfWork.Sizes.Create().ToList();
      Toppings = unitOfWork.Toppings.Create().ToList();
    }

    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
      if (SelectedCrust == SelectedSize)
      {
        yield return new ValidationResult("are you crazy!", new string[] { "SelectedCrust", "SelectedSize" });
      }
      if (SelectedToppings.Count < 2 || SelectedToppings.Count > 5)
      {
        yield return new ValidationResult("No good count");
      }
    }
  }
}
