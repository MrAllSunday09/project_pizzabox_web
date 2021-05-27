using System.Collections.Generic;
using System;

namespace PizzaBox.Domain.Interfaces
{
  public interface IRepository<T> where T : class
  {
    IEnumerable<T> Create(Func<T, bool> filter);
    bool Read(T entry);
    T Update();
    bool Delete();
  }
}