using PizzaBox.Domain.Interfaces;
using System.Collections.Generic;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storing.Repositories
{
  public class ToppingsRepo : IRepository<Topping>
  {
    IEnumerable<Size> IRepository<Topping>()
    {
      throw new System.NotImplementedException();
    }

    public bool Read()
    {
      throw new System.NotImplementedException();
    }

    public Size Update()
    {
      throw new System.NotImplementedException();
    }

    public bool Delete()
    {
      throw new System.NotImplementedException();
    }

    public IEnumerable<Topping> Create()
    {
      return new List<Topping> { new Topping(), new Topping(), new Topping(), new Topping() };
    }

    Topping IRepository<Topping>.Update()
    {
      throw new System.NotImplementedException();
    }
  }
}

