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
      Assert.AreEqual(newPastryOrder.GetTotal(1), 5);
    }

  }
}