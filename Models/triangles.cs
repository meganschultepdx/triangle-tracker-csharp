using System;

namespace Triangles
{

class Triangle
{
  private int A;
  private int B;
  private int C;

//access modifyer: public
  public Triangle(int a, int b, int c) //constructor that takes multiple parameters
  {
  //object's properties = constructor method's parameters
    A = a;
    B = b;
    C = c;
  }

  public string Type()
    {
      if((A < B + C) && (B < A + C) && (C < B + A)){
        if(A == B && A == C && B == C)
        {
          return "an Equilateral Triangle";
        }else if(A == B || A == C || B == C){
          return "an Isosceles Triangle";
        }
        return "a scalene Triangle";
      }else{
        return "not a triangle";
      }
    }
  }
}
