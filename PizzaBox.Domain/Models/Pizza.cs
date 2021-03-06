using System.Collections.Generic;
using System.Linq;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
  public class Pizza : Entity
  {
    public Crust Crust { get; set; }
    public long CrustEntityId { get; set; }
    public Size Size { get; set; }
    public long SizeEntityId { get; set; }
    public Order Order { get; set; }
    public long OrderEntityId { get; set; }
    public List<Topping> Toppings { get; set; }

    public double Payment
    {
      get
      {
        return Size.Price + Toppings.Sum(t => t.Price);
      }
    }
  }
}