namespace Epicodus.Shapes
{
  public class Triangle
  {
    public int A { get; }
    public int B { get; }
    public int C { get; }

    public Triangle(int a, int b, int c)
    {
      A = a;
      B = b;
      C = c;
    }

    public bool IsATriangle()
    {
      if (A > (B+C) || B > (A+C) || C > (A+B)) {
        return false;
      }
      return true;
    }

    public bool IsAScalene()
    {
      if (IsATriangle() && (A != B && A != C && B != C)) {
        return true;
      }
      return false;
    }

    public bool IsAnEquilateral()
    {
      if (IsATriangle() && (A == B && B == C)) {
        return true;
      }
      return false;
    }

    public bool IsAnIsosceles()
    {
      if (IsATriangle() && !IsAScalene() && !IsAEquilateral()) {
        return true;
      }
      return false;
    }
  }
}
