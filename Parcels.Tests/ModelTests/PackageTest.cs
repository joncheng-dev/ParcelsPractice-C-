using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Parcels.Models;
using System;

namespace Parcels.Tests
{

  [TestClass]
  public class PackageTests
  {
    [TestMethod]
    public void PackageConstructor_CreatePackageInstance_Package()
    {
      Package newPackage = new Package(5, 2, 8, 500);
      Assert.AreEqual(typeof(Package), newPackage.GetType());
    }

    [TestMethod]
    public void GetDimensions_CreatePackageInstanceWithParameters_Package()
    {
      int expectedLength = 5;
      int expectedWidth = 2;
      int expectedHeight = 8;
      int expectedWeight = 500;
      Package newPackage = new Package(5, 2, 8, 500);
      Assert.AreEqual(expectedLength, newPackage.Length);
      Assert.AreEqual(expectedWidth, newPackage.Width);
      Assert.AreEqual(expectedHeight, newPackage.Height);
      Assert.AreEqual(expectedWeight, newPackage.Weight);
    }

    [TestMethod]
    public void CalcVolume_ReturnsVolumeOfPackage_Int()
    {
      int expectedVolume = 80;
      Package newPackage = new Package(5, 2, 8, 500);
      int actualVolume = newPackage.CalcVolume();
      Assert.AreEqual(expectedVolume, actualVolume);      
    }

    [TestMethod]
    public void CalcCost_ReturnsCostPriceOfPackage_int()
    {
      int expectedPrice = 8000;
      Package newPackage = new Package(5, 2, 8, 500);
      int actualVolume = newPackage.CalcVolume();
      int actualPrice = newPackage.CalcCost(actualVolume);
      Assert.AreEqual(expectedPrice, actualPrice);
    }
  }
}