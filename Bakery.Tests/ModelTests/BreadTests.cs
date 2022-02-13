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
      public void CreateNewAppointment()
      {
        Bread newBread = new Bread();
        Assert.AreEqual(typeof(Bread), newBread.GetType());
        // Appointment newAppointment = new Appointment("name", "time");
        // Assert.AreEqual(typeof(Appointment), newAppointment.GetType());
      }

    // [TestMethod]
    // public void CreateNewAppointment()
    // {
    //   Appointment newAppointment = new Appointment("name", "time");
    //   Assert.AreEqual(typeof(Appointment), newAppointment.GetType());
    // }

  }
}