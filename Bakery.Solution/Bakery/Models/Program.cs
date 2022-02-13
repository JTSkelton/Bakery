using System;
using System.Collections.Generic;

namespace Bakery
{
public class Program
  {
    public static void Main()
    {

    }
  }
  public class Bread
  {
  public int MakeBread(int loaf)
    {
      if (loaf % 3 == 0) return ((loaf * 5)-((loaf * 5) / 3));
      
      return loaf * 5;
    }
  }

  public class Pastery
  {
  public int MakePastery(int sweet)
    {
      if (sweet == 1) return sweet * 2;

      return ((sweet * 2) - 1);
    }
  }
}
