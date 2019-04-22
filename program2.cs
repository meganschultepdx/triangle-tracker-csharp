using System;
using System.Collections.Generic;

namespace TriangleTracker
{

  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter length of side one: ");
      string stringTriangleSide1 = Console.ReadLine();
      int TriangleSide1 = int.Parse(stringTriangleSide1);

      Console.WriteLine("Enter length of side two: ");
      string stringTriangleSide2 = Console.ReadLine();
      int TriangleSide2 = int.Parse(stringTriangleSide2);

      Console.WriteLine("Enter length of side three: ");
      string stringTriangleSide3 = Console.ReadLine();
      int TriangleSide3 = int.Parse(stringTriangleSide3);

      Triangle toCheck = new Triangle(TriangleSide1, TriangleSide2, TriangleSide3);
      string tri = toCheck.Type();
      Console.WriteLine("This is " + tri);

    }
  }
}
