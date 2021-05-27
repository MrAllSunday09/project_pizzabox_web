using PizzaBox.Domain.Interfaces;
using System.Collections.Generic;
using PizzaBox.Domain.Models;
using System;
using System.Linq;

namespace PizzaBox.Storing.Repositories
{
  public class CrustRepo : IRepository<Crust>
  {
    private readonly PizzaBoxContext _context;
    
    public CrustRepo(PizzaBoxContext context)
    {
      _context = context;
    }
    public IEnumerable<Crust> Create(Func<Crust, bool> filter)
    {
      return _context.Crusts.Where(filter);
    }

    public bool Read(Crust entry)
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