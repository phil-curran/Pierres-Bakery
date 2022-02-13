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
        Bread newBread = new Bread();
        Assert.AreEqual(typeof(Bread), newBread.GetType());
      }

      [TestMethod]
      public void PassNumberToBreadObject_Get_and_Set()
      {
        int order = 5;
        Bread newBread = new Bread();
        newBread.NumberOrdered = order;
        Assert.AreEqual(newBread.NumberOrdered, 5);
      }

      [TestMethod]
      public void GetTotalForOneBread()
      {
        Bread newBread = new Bread(1);
        Assert.AreEqual(newBread.GetTotal(), 1);
      }
    // [TestMethod]
    // public void CreateNewAppointment()
    // {
    //   Appointment newAppointment = new Appointment("name", "time");
    //   Assert.AreEqual(typeof(Appointment), newAppointment.GetType());
    // }

  }
}