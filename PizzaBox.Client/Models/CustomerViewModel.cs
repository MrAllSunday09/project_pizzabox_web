using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PizzaBox.Client.Models
{
  public class CustomerViewModel
  {
    [Required]
    public string SelectedName { get; set; }
  }
}