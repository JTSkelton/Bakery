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
      Bread BreadCost = new Bread(bread);
      var pasteries = System.Console.ReadLine();
      Pastery PasteryCost = new Pastery(pasteries);
      System.Console.WriteLine("Your total cost is: " + (BreadCost.BreadPrice + PasteryCost.PasteryPrice));
    }
  }
}
