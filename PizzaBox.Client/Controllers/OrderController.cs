using PizzaBox.Client.Models;
using Microsoft.AspNetCore.Mvc;


namespace PizzaBox.Client.Controllers
{
  [Route("[controller]")]
  public class OrderController : Controller
  {
    [HttpGet]
    [HttpPost]
    [ValidateAntiForgeryToken]
    public string Order(OrderViewModel order)
    {
      if (ModelState.IsValid)
      {
        return order.SelectedCrust;
      }
      return "Bad Request";
    }
  }
}