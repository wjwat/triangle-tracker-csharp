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
    /*  checkType() {
        if ((this.side1 > (this.side2 + this.side3)) || (this.side2 > (this.side1 + this.side3)) || (this.side3 > (this.side1 + this.side2))) {
          return "not a triangle";
        } else if ((this.side1 !== this.side2) && ((this.side1 !== this.side3)) && ((this.side2 !== this.side3))) {
          return "scalene triangle";
        }  else if ((this.side1 === this.side2) && (this.side1 === this.side3)) {
          return "equilateral triangle";
        } else {
          return "isosceles triangle";
        }
      }    
    }  */

  }
}
