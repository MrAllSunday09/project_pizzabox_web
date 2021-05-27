using PizzaBox.Domain.Interfaces;
using System.Collections.Generic;
using PizzaBox.Domain.Models;
using System;


namespace PizzaBox.Storing.Repositories
{
  public class OrderRepo : IRepository<Order>
  {
    private readonly PizzaBoxContext _context;

    public OrderRepo(PizzaBoxContext context)
    {
      _context = context;
    }

    public IEnumerable<Order> Create(Func<Order, bool> filter)
    {
      throw new System.NotImplementedException();
    }

    public bool Read(Order entry)
    {
      _context.Orders.Add(entry);
      return true;
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
