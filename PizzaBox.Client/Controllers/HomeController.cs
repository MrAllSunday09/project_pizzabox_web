using PizzaBox.Client.Models;
using Microsoft.AspNetCore.Mvc;
using PizzaBox.Storing;

namespace PizzaBox.Client.Controllers
{
  [Route("[controller]/[action]")]
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
      var view = View("index", new OrderViewModel(_unitOfWork));
      return view;
    }
  }
}