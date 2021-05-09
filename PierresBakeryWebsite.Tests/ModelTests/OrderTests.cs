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
    public void GetPrice_ReturnsOrderPrice_int()
    {
      string description = "12 cookies";
      int price = 10;
      string date = "January 1, 2021";
      Order newOrder = new Order(description, price, date);
      Assert.AreEqual(price, newOrder.Price);
    }
    [TestMethod]
    public void GetDate_ReturnsOrderDate_String()
    {
      string description = "12 cookies";
      int price = 10;
      string date = "January 1, 2021";
      Order newOrder = new Order(description, price, date);
      Assert.AreEqual(price, newOrder.Price);
    }
    [TestMethod]
    public void GetId_ReturnsIdOfInstantiatedOrders_Int()
    {
      //Arrange
      string description = "1 loaf of bread";
      int price = 2;
      string date = "January 2, 2021";
      Order testOrder = new Order(description, price, date);

      //Act
      int result = testOrder.Id;

      //Assert
      Assert.AreEqual(1, result);
    }
  }
}