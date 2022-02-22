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

    // Constructor
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

    // IsATriangle
    [TestMethod]
    public void IsATriangle_CheckSides_False()
    {
      Triangle NotATriangle = new Triangle(3, 9, 22);
      Assert.AreEqual(false, NotATriangle.IsATriangle());
    }
    [TestMethod]
    public void IsATriangle_CheckSides_True()
    {
      Triangle IsATriangle = new Triangle(4, 5, 7);
      Assert.AreEqual(true, IsATriangle.IsATriangle());
    }

    // Scalene
    [TestMethod]
    public void IsAScalene_CheckTriangleSides_False()
    {
      Triangle NotAScalene = new Triangle(5, 5, 5);
      Assert.AreEqual(false, NotAScalene.IsAScalene());
    }
    [TestMethod]
    public void IsAScalene_CheckTriangleSides_True()
    {
      Triangle AScalene = new Triangle(2, 3, 4);
      Assert.AreEqual(true, AScalene.IsAScalene());
    }

    // Equilateral
    [TestMethod]
    public void IsAnEquilateral_CheckTriangleSides_False()
    {
      Triangle NotAnEquilateral = new Triangle(2, 3, 4);
      Assert.AreEqual(false, NotAnEquilateral.IsAEquilateral());
    }
    [TestMethod]
    public void IsAnEquilateral_CheckTriangleSides_True()
    {
      Triangle AnEquilateral = new Triangle(5, 5, 5);
      Assert.AreEqual(true, AnEquilateral.IsAEquilateral());
    }

    // Isosceles
    [TestMethod]
    public void IsAnIsosceles_CheckTriangleSides_False()
    {
      Triangle NotAnIsosceles = new Triangle(5, 5, 5);
      Assert.AreEqual(false, NotAnIsosceles.IsAnIsosceles());
    }
    [TestMethod]
    public void IsAnIsosceles_CheckTriangleSides_True()
    {
      Triangle AnIsosceles = new Triangle(5, 5, 7);
      Assert.AreEqual(true, AnIsosceles.IsAnIsosceles());
    }
  }
}
