using PizzaBox.Client.Models;
using Microsoft.AspNetCore.Mvc;
using PizzaBox.Storing;
using PizzaBox.Storing.Repositories;

namespace PizzaBox.Client.Controllers
{
  [Route("[controller]")]
  public class HomeController : Controller
  {

    private readonly UnitOfWork _unitOfWork;

    public HomeController(UnitOfWork unitOfWork)
    {
      _unitOfWork = unitOfWork;
    }

    [HttpGet]
    public IActionResult Index()
    {
      var order = new OrderViewModel();
      order.Construct(_unitOfWork);
      return View("order", order);
    }
  }
}