using System;
using ShapeWorld.Domain.Models;

namespace ShapeWorld.Client
{
    internal class Program
    {
      //access regular return name paramenters
        private static void Main(string[] args)
        {
          PlayWithShape();
        }

        private static void PlayWithShape ()
        {
          
          //Shape someShape = new Shape(10);
          Square someSquare = new Square();
          Rectangle someRectangle = new Rectangle();
          Shape someShape = new Rectangle();

          //casting ex 1 
          Rectangle someRectangle2 = new Rectangle() as Square;
          //cannot do this becase shape is abstract
          // ** Rectangle someRectangle = (Shape) new Rectangle(); **
          // casting  ex 2
          Rectangle someRectangle3 = (Square) new Rectangle ();

          //Rectangle someSquare = new Square ();
          //someShape.NumberOfEdges = 10;
          //someShape.NumberOfEdges = 100;
          
          Console.WriteLine(someShape.NumberOfEdges);
          Console.WriteLine(someSquare.NumberOfEdges);
          Console.WriteLine(someRectangle.NumberOfEdges);
          Console.WriteLine(someShape.Volume());//rectangle volume
          Console.WriteLine(someSquare.Volume());

          
        }
    }
}
