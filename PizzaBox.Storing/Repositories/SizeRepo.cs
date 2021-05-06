using PizzaBox.Domain.Interfaces;
using System.Collections.Generic;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storing.Repositories
{
  public class SizeRepo : IRepository<Size>
  {
    public IEnumerable<Size> Create()
    {
      return new List<Size> { new Size(), new Size() };
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
  }
}