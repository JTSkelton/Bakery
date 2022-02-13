using System;
using System.Collections.Generic;

namespace Bakery
{
public class Program
  {
    public static void Main()
    {
    }
    public int Bread(int loaf)
    {
      if (loaf % 3 == 0)
      {
        return ((loaf * 5)-((loaf * 5) / 3));
      }
      return loaf * 5;
    }

    public int Pastery(int sweet)
    {
      return sweet * 2;
    }
  }
}
