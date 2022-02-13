using System;
using System.Collections.Generic;

namespace Bakery
{
public class Program
  {
    public static void Main()
    {
      System.Console.WriteLine("Hello Welcome To The Bakery!!");
      System.Console.WriteLine("Bread is $5 a loaf. Buy 2 get one freeeee!");
      System.Console.WriteLine("Pasteries are $2 a piece. One dollar off orders over 1!");
      System.Console.WriteLine("How much bread would you like? Please enter a number.");
      var bread = System.Console.ReadLine();
      System.Console.WriteLine("How many pasteries would you like? Please enter a number.");
      var pasteries = System.Console.ReadLine();
      Bread BreadCost = new Bread();
      Pastery PasteryCost = new Pastery();
      System.Console.WriteLine("Your total cost is: " + (BreadCost.MakeBread(Convert.ToInt32(bread)) + PasteryCost.MakePastery(Convert.ToInt32(pasteries))));
    }
  }
  public class Bread
  {
  public int MakeBread(int loaf)
    {
      if (loaf <= 0) return 0;
      if (loaf % 3 == 0) return ((loaf * 5)-((loaf * 5) / 3));
      
      return loaf * 5;
    }
  }

  public class Pastery
  {
  public int MakePastery(int sweet)
    {
      if (sweet <= 0) return 0;
      if (sweet == 1) return sweet * 2;

      return ((sweet * 2) - 1);
    }
  }
}
