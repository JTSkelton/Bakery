using System; 

namespace Bakery
{
  
  public class Bread
  {
    public int BreadPrice { get; set; }
  
  public Bread(string breadOrder)
  {
    BreadPrice = MakeBread(Convert.ToInt32(breadOrder));
  }
  public int MakeBread(int loaf)
    {
      if (loaf <= 0) return 0;
      if (loaf % 3 == 0) return ((loaf * 5)-((loaf * 5) / 3));
      
      return loaf * 5;
    }
  }
}
