using PizzaBox.Domain.Interfaces;
using System.Collections.Generic;
using PizzaBox.Domain.Models;
using System;


namespace PizzaBox.Storing.Repositories
{
  public class CustomerRepo : IRepository<Customer>
  {
    private readonly PizzaBoxContext _context;

    public CustomerRepo(PizzaBoxContext context)
    {
      _context = context;
    }

    public IEnumerable<Customer> Create(Func<Customer, bool> filter)
    {
      throw new System.NotImplementedException();
    }

    public bool Read(Customer entry)
    {
      _context.Customers.Add(entry);
      return true;
    }

    public Customer Update()
    {
      throw new System.NotImplementedException();
    }

    public bool Delete()
    {
      throw new System.NotImplementedException();
    }
  }
}
