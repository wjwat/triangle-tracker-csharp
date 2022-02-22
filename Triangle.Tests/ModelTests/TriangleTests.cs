using Microsoft.VisualStudio.TestTools.UnitTesting;
using Epicodus.Shapes;

namespace Epicodus.Shapes.Tests
{
  [TestClass]
  public class TriangleTests
  {
    static int SideA = 4;
    static int SideB = 5;
    static int SideC = 6;
    Triangle t = new Triangle(SideA, SideB, SideC);

    [TestMethod]
    public void Constructor_TriangleSides_AEqualsPassedInValue()
    {
      Assert.AreEqual(SideA, t.A);
    }
    [TestMethod]
    public void Constructor_TriangleSides_BEqualsPassedInValue()
    {
      Assert.AreEqual(SideB, t.B);
    }
    [TestMethod]
    public void Constructor_TriangleSides_CEqualsPassedInValue()
    {
      Assert.AreEqual(SideC, t.C);
    }
  }
}
