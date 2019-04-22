using System;
using System.Collections.Generic;

namespace Triangles {

public class Program //basic boilerplate code
{
  public static void Main()
  {

    Console.WriteLine("Enter Side 1:");
    int side1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter Side 2:");
    int side2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter Side 3:");
    int side3 = int.Parse(Console.ReadLine());

    Triangle toCheck = new Triangle(side1, side2, side3);
    string tri = toCheck.Type();
    Console.WriteLine("This is " + tri);
    }
  }
}
