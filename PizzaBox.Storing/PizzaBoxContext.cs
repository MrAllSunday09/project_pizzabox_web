using System.Linq;
using Microsoft.EntityFrameworkCore;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storing
{
  public class PizzaBoxContext : DbContext
  {
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Store> Stores { get; set; }
    public DbSet<Crust> Crusts { get; set; }

    public DbSet<Size> Sizes { get; set; }

    public DbSet<Topping> Toppings { get; set; }

    public DbSet<Order> Orders { get; set; }

    public DbSet<Pizza> Pizzas { get; set; }

    public PizzaBoxContext(DbContextOptions options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Customer>().HasKey(e => e.EntityId);
      builder.Entity<Store>().HasKey(e => e.EntityId);
      builder.Entity<Order>().HasKey(e => e.EntityId);
      builder.Entity<Pizza>().HasKey(e => e.EntityId);
      builder.Entity<Size>().HasKey(e => e.EntityId);
      builder.Entity<Crust>().HasKey(e => e.EntityId);
      builder.Entity<Topping>().HasKey(e => e.EntityId);

      OnModelSeeding(builder);
    }

    private static void OnModelSeeding(ModelBuilder builder)
    {
      builder.Entity<Store>().HasData(new[]
      {
        new Store() { EntityId = 1, Name = "Domino's" },
        new Store() { EntityId = 2, Name = "Pizza Hut" },
        new Store() { EntityId = 3, Name = "Marco's" },
        new Store() { EntityId = 4, Name = "Mellow Mushroom" },
        new Store() { EntityId = 5, Name = "Hungry Howie's" },
        new Store() { EntityId = 6, Name = "Pizza Inn" }
      });

      builder.Entity<Crust>().HasData(new[]
      {
        new Crust() { EntityId = 1, Name = "Thin" },
        new Crust() { EntityId = 2, Name = "Original" },
        new Crust() { EntityId = 3, Name = "Brooklyn" },
        new Crust() { EntityId = 4, Name = "Deep Dish" },
        new Crust() { EntityId = 5, Name = "Stuffed" }
      });

      builder.Entity<Size>().HasData(new[]
      {
        new Size() { EntityId = 1, Name = "Small" },
        new Size() { EntityId = 2, Name = "Medium" },
        new Size() { EntityId = 3, Name = "Large"},
        new Size() { EntityId = 4, Name = "X-Large"}
      });

      builder.Entity<Topping>().HasData(new[]
      {
        new Topping() { EntityId = 1, Name = "Bacon" },
        new Topping() { EntityId = 2, Name = "Sausage" },
        new Topping() { EntityId = 3, Name = "Chicken" },
        new Topping() { EntityId = 4, Name = "Spinach" },
        new Topping() { EntityId = 5, Name = "Peppers" },
        new Topping() { EntityId = 6, Name = "Pepperoni" },
        new Topping() { EntityId = 7, Name = "Ham" },
        new Topping() { EntityId = 8, Name = "Pineapple" },
        new Topping() { EntityId = 9, Name = "Mushrooms" },
        new Topping() { EntityId = 10, Name = "Onion" }
      });
    }
  }
}
