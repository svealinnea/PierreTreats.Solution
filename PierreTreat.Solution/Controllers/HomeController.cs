using Microsoft.AspNetCore.Mvc;

namespace PierreTreat.Controllers
{
  public class HomeController : Controller
  {
    
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

  }
}