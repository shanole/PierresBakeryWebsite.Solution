using Microsoft.AspNetCore.Mvc;

namespace PierresBakerWebsite.Controllers
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