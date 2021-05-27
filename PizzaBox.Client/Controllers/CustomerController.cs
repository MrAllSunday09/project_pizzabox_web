using PizzaBox.Client.Models;
using Microsoft.AspNetCore.Mvc;

namespace PizzaBox.Client.Controllers
{
  [Route("[controller]")]
  public class CustomerController : Controller
  {
    [HttpGet]
    [HttpPost]
    [ValidateAntiForgeryToken]

    public string Customer(CustomerViewModel customer)
    {
      if (ModelState.IsValid)
      {
        return customer.SelectedName;
      }
      return "Enter Name:";
    }
  }
}