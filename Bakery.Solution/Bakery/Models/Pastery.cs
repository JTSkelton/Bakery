using System;

namespace Bakery
{
  public class Pastery
  {

  public int PasteryPrice { get; set; }
  
  public Pastery(string pasteryOrder)
  {
    PasteryPrice = MakePastery(Convert.ToInt32(pasteryOrder));
  }
  public int MakePastery(int sweet)
    {
      if (sweet <= 0) return 0;
      if (sweet == 1) return sweet * 2;

      return ((sweet * 2) - 1);
    }
  }

  }