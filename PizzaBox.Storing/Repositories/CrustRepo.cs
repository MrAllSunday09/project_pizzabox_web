using PizzaBox.Domain.Interfaces;
using System.Collections.Generic;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storing.Repositories
{
  public class CrustRepo : IRepository<Crust>
  {
    public IEnumerable<Crust> Create()
    {
      return new List<Crust> { new Crust(), new Crust() };
    }

    public bool Read()
    {
      throw new System.NotImplementedException();
    }

    public Crust Update()
    {
      throw new System.NotImplementedException();
    }

    public bool Delete()
    {
      throw new System.NotImplementedException();
    }
  }
}