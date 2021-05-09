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
      Vendor newVendor = new Vendor();
      Assert.AreEqual(typeof(Vendor),newVendor.GetType()); 
    }
  }
}