using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PierresBakeryWebsite.Models;

namespace PierresBakeryWebsite.Models
{
  public class OrdersController : Controller
  {
    [HttpGet("/vendors/{vendorId}/orders/new")]
    public ActionResult New(int vendorId)
    {
      Vendor selectedVendor = Vendor.Find(vendorId);
      return View(selectedVendor);
    }
  }
}