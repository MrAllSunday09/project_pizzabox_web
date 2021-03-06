using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.Models;
using PizzaBox.Domain.Models;
using PizzaBox.Storing;

namespace PizzaBox.Client.Controllers
{
  [Route("[controller]")]
  public class OrderController : Controller
  {
    private readonly UnitOfWork _unitOfWork;

    public OrderController(UnitOfWork unitOfWork)
    {
      _unitOfWork = unitOfWork;
    }

    [HttpGet]
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Order(OrderViewModel order)
    {
      if (ModelState.IsValid)
      {
        var crust = _unitOfWork.Crusts.Create(c => c.Name == order.SelectedCrust).First();
        var size = _unitOfWork.Sizes.Create(s => s.Name == order.SelectedSize).First();
        var toppings = new List<Topping>();

        foreach (var item in order.SelectedToppings)
        {
          toppings.Add(_unitOfWork.Toppings.Create(t => t.Name == item).First());
        }

        var newPizza = new Pizza { Crust = crust, Size = size, Toppings = toppings };
        var newOrder = new Order { Pizzas = new List<Pizza> { newPizza } };

        _unitOfWork.Orders.Read(newOrder);
        _unitOfWork.Save();

        ViewBag.Order = newOrder;

        return View("Checkout");
      }

      order.Construct(_unitOfWork);

      return View("order", order);
    }
  }
}