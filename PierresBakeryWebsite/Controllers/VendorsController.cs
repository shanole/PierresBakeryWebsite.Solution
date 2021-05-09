using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using PierresBakeryWebsite.Models;

namespace PierresBakeryWebsite.Controllers
{
  public class VendorsController : Controller
  {
    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }
  }
}