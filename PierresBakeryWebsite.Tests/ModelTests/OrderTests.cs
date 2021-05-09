using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakeryWebsite.Models;
using System.Collections.Generic;
using System;

namespace PierresBakeryWebsite.Tests
{
  [TestClass]
  public class OrderTests
  {
    [TestMethod]
    public void OrderConstructor_CreatesInstanceofOrder_Order()
    {
      Order newOrder = new Order("One dozen loaves of bread", 24, "April 21, 2021");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]
    public void GetDescription_ReturnsOrderDescription_String()
    {
      string description = "12 cookies";
      int price = 10;
      string date = "January 1, 2021";
      Order newOrder = new Order(description, price, date);
      Assert.AreEqual(description, newOrder.Description);
    }
    [TestMethod]
    public void GetPrice_ReturnsOrderDescription_String()
    {
      string description = "12 cookies";
      int price = 10;
      string date = "January 1, 2021";
      Order newOrder = new Order(description, price, date);
      Assert.AreEqual(price, newOrder.Price);
    }
  }
}