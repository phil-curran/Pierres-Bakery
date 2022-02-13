using System;

namespace Bakery.Models
{
  public class Bread
  {
    public int NumberOrdered { get; set; }

    public int GetTotal(int numberOrdered)
    {
      int total = numberOrdered * 5;
      return total;
    }

  }
}