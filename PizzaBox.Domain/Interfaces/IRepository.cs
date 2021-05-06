using System.Collections.Generic;

namespace PizzaBox.Domain.Interfaces
{
  public interface IRepository<T> where T : class
  {
    IEnumerable<T> Create();
    bool Read();
    T Update();
    bool Delete();
  }
}