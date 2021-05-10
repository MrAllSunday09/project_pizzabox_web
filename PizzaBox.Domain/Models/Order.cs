using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
using System.Linq;

namespace PizzaBox.Domain.Models
{
  public class Order : Entity
  {
    public List<Pizza> Pizzas { get; set; }

    public Customer Customer { get; set; }
    public Store Store { get; set; }
    public double Money
    {
      get
      {
        return Pizzas.Sum(p => p.Payment);
      }
    }
  }
}