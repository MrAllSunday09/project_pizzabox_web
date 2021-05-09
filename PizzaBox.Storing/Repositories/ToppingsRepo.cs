using PizzaBox.Domain.Interfaces;
using System.Collections.Generic;
using PizzaBox.Domain.Models;
using System;
using System.Linq;

namespace PizzaBox.Storing.Repositories
{
  public class ToppingsRepo : IRepository<Topping>
  {
    private readonly PizzaBoxContext _context;

    public ToppingsRepo(PizzaBoxContext context)
    {
      _context = context;
    }
    public IEnumerable<Topping> Create(Func<Topping, bool> filter)
    {
      return _context.Toppings.Where(filter);
    }

    public bool Read(Topping entry)
    {
      throw new System.NotImplementedException();
    }

    public Topping Update()
    {
      throw new System.NotImplementedException();
    }

    public bool Delete()
    {
      throw new System.NotImplementedException();
    }
  }
}

