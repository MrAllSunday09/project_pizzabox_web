using PizzaBox.Domain.Interfaces;
using System.Collections.Generic;
using PizzaBox.Domain.Models;
using System;
using System.Linq;

namespace PizzaBox.Storing.Repositories
{
  public class SizeRepo : IRepository<Size>
  {
    private readonly PizzaBoxContext _context;
    
    public SizeRepo(PizzaBoxContext context)
    {
      _context = context;
    }
    public IEnumerable<Size> Create(Func<Size, bool> filter)
    {
      return _context.Sizes.Where(filter);
    }

    public bool Read(Size entry)
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
  }
}