using System;

namespace Bakery.Models
{
  public class Bread
  {
    public int NumberOrdered { get; set; }

    public string ErrorMessage()
    {
      string errorMessage = "error message";
      return errorMessage;
    }

    public int GetTotal(int numberOrdered)
    {
      int price = 5;
      int total = 0;

      if (numberOrdered % 3 == 0)
      {
        total = (numberOrdered / 3 * 2) * price;
      }
      else if (numberOrdered % 3 < 3)
      {
        int diff = numberOrdered % 3;
        int temp = numberOrdered - diff;
        total = ((temp / 3 * 2) * price) + (diff * price);
      }
      return total;

    }

  }
}