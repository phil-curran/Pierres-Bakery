using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Models
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void CreateNewPastryObject()
    {
      Pastry newPastryOrder = new Pastry();
      Assert.AreEqual(typeof(Pastry), newPastryOrder.GetType());
    }

    [TestMethod]
    public void PassNumberToPastryObject_Get_and_Set()
    {
      int order = 5;
      Pastry newPastryOrder = new Pastry();
      newPastryOrder.NumberOrdered = order;
      Assert.AreEqual(newPastryOrder.NumberOrdered, 5);
    }

    [TestMethod]
    public void GetTotalForOnePastry()
    {
      Pastry newPastryOrder = new Pastry();
      Assert.AreEqual(newPastryOrder.GetTotal(1), 2);
    }

    [TestMethod]
    public void GetTotalForTwoPastries()
    {
      Pastry newPastryOrder = new Pastry();
      Assert.AreEqual(newPastryOrder.GetTotal(2), 4);
    }

    [TestMethod]
    public void GetTotalForThreePastries()
    {
      Pastry newPastryOrder = new Pastry();
      Assert.AreEqual(newPastryOrder.GetTotal(3), 5);
    }

    [TestMethod]
    public void GetTotalForFourPastries()
    {
      Pastry newPastryOrder = new Pastry();
      Assert.AreEqual(newPastryOrder.GetTotal(4), 7);
    }

    [TestMethod]
    public void GetTotalForFivePastries()
    {
      Pastry newPastryOrder = new Pastry();
      Assert.AreEqual(newPastryOrder.GetTotal(5), 9);
    }

    [TestMethod]
    public void GetTotalForSixPastries()
    {
      Pastry newPastryOrder = new Pastry();
      Assert.AreEqual(newPastryOrder.GetTotal(6), 10);
    }

    [TestMethod]
    public void GetTotalForSevenPastries()
    {
      Pastry newPastryOrder = new Pastry();
      Assert.AreEqual(newPastryOrder.GetTotal(7), 12.25);
    }

    [TestMethod]
    public void GetTotalForOneMillionPastries()
    {
      Pastry newPastryOrder = new Pastry();
      Assert.AreEqual(newPastryOrder.GetTotal(1000000), 1750000);
    }

    [TestMethod]
    public void GetTotalForZEROPastries()
    {
      Pastry newPastryOrder = new Pastry();
      Assert.AreEqual(newPastryOrder.GetTotal(0), 0);
    }

  }
}