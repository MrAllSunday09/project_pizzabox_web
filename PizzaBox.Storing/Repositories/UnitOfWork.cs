using PizzaBox.Storing.Repositories;

namespace PizzaBox.Storing
{
  public class UnitOfWork
  {
    public CrustRepo Crusts { get; }
    public SizeRepo Sizes { get; }
    public ToppingsRepo Toppings { get; }

    public UnitOfWork()
    {
      Crusts = new CrustRepo();
      Sizes = new SizeRepo();
      Toppings = new ToppingsRepo();

    }
  }
}