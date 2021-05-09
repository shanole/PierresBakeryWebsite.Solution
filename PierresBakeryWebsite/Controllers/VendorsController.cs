using System.Collections.Generic;
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
    [HttpPost("/vendors")]
    public ActionResult Create(string vendorName, string vendorDescription)
    {
      Vendor newVendor = new Vendor(vendorName, vendorDescription);
      return RedirectToAction("Index");
    }
    [HttpGet("/vendors/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string,object> model = new Dictionary<string,object> {};
      Vendor selectedVendor = Vendor.Find(id);
      List<Order> vendorOrders = selectedVendor.Orders;
      model.Add("vendor",selectedVendor);
      model.Add("orders",vendorOrders);
      return View(model);
    }
    [HttpPost("/vendors/{vendorId}/orders")]
    public ActionResult Create(int vendorId, string orderDescription, int orderPrice, string orderDate)
    {
      Dictionary<string, object> model = new Dictionary<string, object>{};
      Vendor selectedVendor = Vendor.Find(vendorId);
      Order newOrder = new Order(orderDescription, orderPrice, orderDate);
      selectedVendor.AddOrder(newOrder);
      List<Order> vendorItems = selectedVendor.Orders;
      model.Add("vendor",selectedVendor);
      model.Add("orders",vendorItems);
      return View("Show",model);
    }
  }
}