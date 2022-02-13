using System;
using Bakery.Models;

namespace Bakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("Here's our current menu:");
      Console.WriteLine("---------------------------------");
      Console.WriteLine("Breads:");
      Console.WriteLine("Amount: \tCost:");
      Console.WriteLine("1\t\t$5");
      Console.WriteLine("2+\t\t$Buy two, get a third free");
      Console.WriteLine("\n");
      Console.WriteLine("Pastries:");
      Console.WriteLine("Amount: \tCost:");
      Console.WriteLine("1\t\t$2");
      Console.WriteLine("2\t\t$4");
      Console.WriteLine("3\t\t$5");
      Console.WriteLine("4\t\t$7");
      Console.WriteLine("5\t\t$9");
      Console.WriteLine("6\t\t$10");
      Console.WriteLine("7+\t\t$1.75 ea");
      Console.WriteLine("\n");
      Console.WriteLine("Enter number of bread loaves to purchase: ");
      string breadOrder = Console.ReadLine();
      int breadsOrdered = int.Parse(breadOrder);
      Bread newBreadOrder = new Bread();
      Console.WriteLine("Enter number of pastries to purchase: ");
      string pastryOrder = Console.ReadLine();
      int pastriesOrdered = int.Parse(pastryOrder);
      Pastry newPastryOrder = new Pastry();
      float total = (float)(newBreadOrder.GetTotal(breadsOrdered) + newPastryOrder.GetTotal(pastriesOrdered));
      Console.WriteLine("Your order total is: $" + total);

      // string stringMaxPrice = Console.ReadLine();
      // int maxPrice = int.Parse(stringMaxPrice);

      // List<Car> CarsMatchingSearch = new List<Car>(0);

      // foreach (Car automobile in Cars)
      // {
      //   if (automobile.WorthBuying(maxPrice))
      //   {
      //     CarsMatchingSearch.Add(automobile);
      //   }
      // }

      // foreach(Car automobile in CarsMatchingSearch)
      // {
      //   Console.WriteLine(automobile.MakeModel);
      // }
    }
  }
}