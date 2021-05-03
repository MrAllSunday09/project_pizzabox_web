using PizzaBox.Client.Models;
using Microsoft.AspNetCore.Mvc;


namespace _PizzaBox.Client.Controllers
{
  [Route("[controller]/[action]")]
  public class HomeController : Controller
  {
    [HttpGet]

    public IActionResult Index()
    {
      ViewBag.Order = new OrderViewModel();
      return View("index");
    }
  }
}