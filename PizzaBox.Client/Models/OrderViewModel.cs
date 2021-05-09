using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using PizzaBox.Domain.Models;
using PizzaBox.Storing;
using PizzaBox.Storing.Repositories;

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


    public void Construct(UnitOfWork unitOfWork)
    {
      Crusts = unitOfWork.Crusts.Create(c => !string.IsNullOrWhiteSpace(c.Name)).ToList();
      Sizes = unitOfWork.Sizes.Create(s => !string.IsNullOrWhiteSpace(s.Name)).ToList();
      Toppings = unitOfWork.Toppings.Create(t => !string.IsNullOrWhiteSpace(t.Name)).ToList();
    }

    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
      if (SelectedToppings.Count < 2 || SelectedToppings.Count > 5)
      {
        yield return new ValidationResult("Please select at least 2, but no more than 5 toppings", new[] { "SelectedToppings" });
      }
    }
  }
}