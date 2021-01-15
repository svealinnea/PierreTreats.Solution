using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using PierreTreat.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
namespace PierreTreat.Controllers
{
  public class HomeController : Controller
  {
    private readonly PierreTreatContext _db;
    public HomeController(PierreTreatContext db)
    {
      _db = db;
    }
    [HttpGet("/")]
    public ActionResult Index()
    {
      List<Treat> treatList = _db.Treats.ToList();
      List<Flavor> flavorList = _db.Flavors.ToList();
      ViewBag.TreatList = treatList;
      ViewBag.FlavorList = flavorList;
      ViewBag.Treats = _db.Treats;
      ViewBag.Flavors = _db.Flavors;
      return View();
    }

  }
}