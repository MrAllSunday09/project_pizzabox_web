using PizzaBox.Domain.Interfaces;
using System.Collections.Generic;
using PizzaBox.Domain.Models;
using System;


namespace PizzaBox.Storing.Repositories
{
  public class StoreRepo : IRepository<Store>
  {
    private readonly PizzaBoxContext _context;

    public StoreRepo(PizzaBoxContext context)
    {
      _context = context;
    }

    public IEnumerable<Store> Create(Func<Store, bool> filter)
    {
      throw new System.NotImplementedException();
    }

    public bool Read(Store entry)
    {
      _context.Stores.Add(entry);
      return true;
    }

    public Store Update()
    {
      throw new System.NotImplementedException();
    }

    public bool Delete()
    {
      throw new System.NotImplementedException();
    }
  }
}
