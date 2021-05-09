using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakeryWebsite.Models;
using System.Collections.Generic;
using System;

namespace PierresBakeryWebsite.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }
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
    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      //Arrange
      Vendor testVendor1 = new Vendor("Costco","wholesale outlet");
      Vendor testVendor2 = new Vendor("Cafe","local restaurant");

      //Act
      Vendor result = Vendor.Find(2);

      //Assert
      Assert.AreEqual(testVendor2,result);
    }
    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      //Arrange
      Vendor testVendor1 = new Vendor("Costco","wholesale outlet");
      Vendor testVendor2 = new Vendor("Cafe","local restaurant");
      List<Vendor> testList = new List<Vendor> {testVendor1, testVendor2};

      //Act
      List<Vendor> result = Vendor.GetAll();

      //Assert
      CollectionAssert.AreEqual(testList,result);
    }
  }
}