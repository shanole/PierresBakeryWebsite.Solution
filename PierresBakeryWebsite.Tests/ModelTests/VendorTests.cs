using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakeryWebsite.Models;
using System.Collections.Generic;
using System;

namespace PierresBakeryWebsite.Tests
{
  [TestClass]
  public class VendorTests
  {
    [TestMethod]
    public void VendorContructor_CreatesInstanceofVendor_Vendor()
    {
      Vendor newVendor = new Vendor("Vendor Name", "Vendor description");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "Costco";
      string description = "wholesale outlet";
      Vendor newVendor = new Vendor(name, description);
      Assert.AreEqual(name, newVendor.Name);
    }
    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string name = "Costco";
      string description = "wholesale outlet";
      Vendor newVendor = new Vendor(name, description);
      Assert.AreEqual(description, newVendor.Description);
    }
    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      //Arrange
      string name = "Costco";
      string description = "wholesale outlet";
      Vendor newVendor = new Vendor(name, description);

      //Act
      int result = newVendor.Id;

      //Assert
      Assert.AreEqual(1,result);
    }
  }
}