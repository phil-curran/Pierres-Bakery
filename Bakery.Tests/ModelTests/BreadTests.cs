using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Models
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
      public void CreateNewBreadObject()
      {
        Bread newBreadOrder = new Bread();
        Assert.AreEqual(typeof(Bread), newBreadOrder.GetType());
      }

      [TestMethod]
      public void PassNumberToBreadObject_Get_and_Set()
      {
        int order = 5;
        Bread newBreadOrder = new Bread();
        newBreadOrder.NumberOrdered = order;
        Assert.AreEqual(newBreadOrder.NumberOrdered, 5);
      }

      [TestMethod]
      public void GetTotalForOneBread()
      {
        Bread newBreadOrder = new Bread();
        Assert.AreEqual(newBreadOrder.GetTotal(1), 5);
      }

      [TestMethod]
      public void GetTotalForTwoBreads()
      {
        Bread newBreadOrder = new Bread();
        Assert.AreEqual(newBreadOrder.GetTotal(2), 10);
      }

      [TestMethod]
      public void GetTotalForThreeBreads()
      {
        Bread newBreadOrder = new Bread();
        Assert.AreEqual(newBreadOrder.GetTotal(3), 10);
      }

      [TestMethod]
      public void GetTotalForFourBreads()
      {
        Bread newBreadOrder = new Bread();
        Assert.AreEqual(newBreadOrder.GetTotal(4), 15);
      }

      [TestMethod]
      public void GetTotalForFiveBreads()
      {
        Bread newBreadOrder = new Bread();
        Assert.AreEqual(newBreadOrder.GetTotal(5), 20);
      }

      [TestMethod]
      public void GetTotalForSixBreads()
      {
        Bread newBreadOrder = new Bread();
        Assert.AreEqual(newBreadOrder.GetTotal(6), 20);
      }

      [TestMethod]
      public void GetTotalForSevenBreads()
      {
        Bread newBreadOrder = new Bread();
        Assert.AreEqual(newBreadOrder.GetTotal(7), 25);
      }

      [TestMethod]
      public void GetTotalForOneMillionBreads()
      {
        Bread newBreadOrder = new Bread();
        Assert.AreEqual(newBreadOrder.GetTotal(1000000), 3333335);
      }

      [TestMethod]
      public void GetTotalForZEROBreads()
      {
        Bread newBreadOrder = new Bread();
        Assert.AreEqual(newBreadOrder.GetTotal(0), 0);
      }

      [TestMethod]
      public void GetTotalForNegativeBreads()
      {
        Bread newBreadOrder = new Bread();
        Assert.AreEqual(newBreadOrder.GetTotal(-4), "error message");
      }

  }
}