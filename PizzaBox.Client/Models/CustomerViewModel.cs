using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PizzaBox.Storing;

namespace PizzaBox.Client.Models
{
  public class CustomerViewModel : IValidatableObject
  {
    [Required(ErrorMessage = "Please Enter Your Name")]
    [DataType(DataType.Text)]
    public string SelectedName { get; set; }

    [Required(ErrorMessage = "Please Enter Address")]
    [DataType(DataType.Text)]
    public string SelectedAddress { get; set; }

    [Required(ErrorMessage = "Please Enter Phone Number")]
    [DataType(DataType.Text)]
    public long SelectedNumber { get; set; }


    public void Construct(UnitOfWork unitOfWork)
    {
      Customers = unitOfWork.Customers.Create(c => !string.IsNullOrWhiteSpace(c.Name)).ToList();
    }

    // public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    // {
    // if (SelectedToppings.Count < 2 || SelectedToppings.Count > 5)
    // {
    //   yield return new ValidationResult("Please select at least 2, but no more than 5 toppings", new[] { "SelectedToppings" });
    // }
  }
}
}