using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery;

namespace Bakery.Tests
{
  [TestClass]
  public class ProgramTests
  {
    [TestMethod]
    public void Bread_ReturnLoafCost_5()
    {
      Bread testBread = new Bread();
      Assert.AreEqual(5, testBread.MakeBread(1));
    } 

    [TestMethod]
    public void Bread_Return3LoafCost_10()
    {
      Bread testBread = new Bread();
      Assert.AreEqual(10, testBread.MakeBread(3));
    } 

    [TestMethod]
    public void Pastery_Return1PasteryCost_2()
    {
      Pastery testPastery = new Pastery();
      Assert.AreEqual(2, testPastery.MakePastery(1));
    } 

    [TestMethod]
    public void Pastery_Return5PasteryCost_9()
    {
      Pastery testPastery = new Pastery();
      Assert.AreEqual(9, testPastery.MakePastery(5));
    } 
  }
}