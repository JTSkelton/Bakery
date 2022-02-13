using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery;

namespace Bakery.Tests
{
  [TestClass]
  public class ProgramTests
  {
    [TestMethod]
    public void Bread_ReturnFalse_False()
    {
      Program testBread = new Program();
      Assert.AreEqual(true, testBread.Bread(1));
    } 
  }
}