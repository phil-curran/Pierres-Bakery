using System;

namespace Bakery.Models
{
  public class Pastry
  {

    public int NumberOrdered { get; set; }

    public double GetTotal(double numberOrdered)
    {
      double total = 0;

      if (numberOrdered == 1)
      {
        total = 2;
      }
      else if (numberOrdered == 2)
      {
        total = 4;
      } else if (numberOrdered == 3)
      {
        total = 5;
      } else if (numberOrdered == 4)
      {
        total = 7;
      } else if (numberOrdered == 5)
      {
        total = 9;
      }else if (numberOrdered == 6)
      {
        total = 10;
      } else {
        total = numberOrdered * 1.75;
      }
      return total;
    }
  }
}