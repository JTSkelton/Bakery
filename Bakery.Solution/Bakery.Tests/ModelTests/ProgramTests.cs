using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery;

namespace Bakery.Tests
{
  [TestClass]
  public class ProgramTests
  {
    [TestMethod]
    public void Bread_ReturnLoafCoast_5()
    {
      Program testBread = new Program();
      Assert.AreEqual(5, testBread.Bread(1));
    } 

    [TestMethod]
    public void Bread_Return3LoafCost_10()
    {
      Program testBread = new Program();
      Assert.AreEqual(10, testBread.Bread(3));
    } 
  }
}