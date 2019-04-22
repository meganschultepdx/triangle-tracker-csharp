using System;

namespace TriangleTracker
{

  class Triangle
  {
    private int A;
    private int B;
    private int C;

    public Triangle(int a, int b, int c)
    {
      A = a;
      B = b;
      C = c;
    }

  public string Type()
    {
      if ((A > B + C) || (B > A + C) || (C > A + B))
      {
        return "Not a triangle";
      }
      else if (A == B && B == C)
      {
        return "Equilateral triangle";
      }
      else if ((A == B) || (B == C) || (A == C))
      {
        return "Isosceles triangle";
      }
      else
      {
        return "Scalene triangle";
      }
    }
  }
}
