using Microsoft.AspNetCore.Mvc;

namespace Parcels.Controllers
{
  public class HomeController : Controllers
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}