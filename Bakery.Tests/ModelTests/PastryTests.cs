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

  }
}