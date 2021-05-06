using PizzaBox.Domain.Interfaces;
using System.Collections.Generic;
using PizzaBox.Domain.Models;
using System.Linq;


namespace PizzaBox.Storing.Repositories
{
  public class OrderRepo : IRepository<Order>
  {
    public IEnumerable<Order> Create()
    {
      throw new System.NotImplementedException();
    }

    public bool Read()
    {
      throw new System.NotImplementedException();
    }

    public Order Update()
    {
      throw new System.NotImplementedException();
    }

    public bool Delete()
    {
      throw new System.NotImplementedException();
    }
  }
}
