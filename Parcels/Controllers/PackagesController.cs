using Microsoft.AspNetCore.Mvc;
using Parcels.Models;

namespace Parcels.Controllers
{
  public class PackagesController : Controller
  {
    [HttpGet("/packages")]
    public ActionResult Index()
    {
      return View();
    }
    
    [HttpPost("/order")]
    public ActionResult Order(string length, string width, string height, string weight)
    {
      Package userEnteredPkg = new Package(length, width, height, weight);
      return View(userEnteredPkg);
    }
  }
}