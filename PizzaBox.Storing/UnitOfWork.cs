using PizzaBox.Storing.Repositories;

namespace PizzaBox.Storing
{
  public class UnitOfWork
  {
    private readonly PizzaBoxContext _context;

    public CrustRepo Crusts { get; }
    public OrderRepo Orders { get; set; }
    public PizzaRepo Pizzas { get; set; }
    public SizeRepo Sizes { get; }
    public ToppingsRepo Toppings { get; }

    public UnitOfWork(PizzaBoxContext context)
    {
      _context = context;

      Crusts = new CrustRepo(_context);
      Orders = new OrderRepo(_context);
      Pizzas = new PizzaRepo(_context);
      Sizes = new SizeRepo(_context);
      Toppings = new ToppingsRepo(_context);
    }

    public void Save()
    {
      _context.SaveChanges();
    }
  }
}