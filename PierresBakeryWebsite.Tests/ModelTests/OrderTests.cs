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
      Order newOrder = new Order();
      Assert.AreEqual(typeof(Order),newOrder.GetType());
    }
  }
}