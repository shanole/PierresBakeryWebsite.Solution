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
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }
  }
}