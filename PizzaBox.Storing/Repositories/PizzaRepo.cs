using System;
using System.Collections.Generic;
using PizzaBox.Domain.Interfaces;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storing.Repositories
{
  public class PizzaRepo : IRepository<Pizza>
  {
    private readonly PizzaBoxContext _context;

    public PizzaRepo(PizzaBoxContext context)
    {
      _context = context;
    }

    public bool Delete()
    {
      throw new System.NotImplementedException();
    }

    public bool Read(Pizza entry)
    {
      throw new System.NotImplementedException();
    }

    public IEnumerable<Pizza> Create(Func<Pizza, bool> filter)
    {
      throw new System.NotImplementedException();
    }

    public Pizza Update()
    {
      throw new System.NotImplementedException();
    }
  }
}
