namespace ShapeWorld.Domain.Models
{
    public abstract class Shape
    {
      //fileds

      //when you make a field private it becomes backing fields
      //private int numberOfEdges;
      
      //properties = field that has the workings of a method (always public)
      // field masquarading as a method

      //public int NumberOfEdges {get; private set;}
      public int NumberOfEdges { get;}

     
      //methods
      // computer can generate (you can come up with a value)
      public virtual double Perimeter()
      {
        return 0;

      }
      //upto the user to come up with not upto the computer ( you must come up with a value)
      public abstract double Area();

      public double Volume ()
      {
        return 0;
      }

      /* 
      public int GetEdges()
      {
        return numberOfEdges;
      }

      public void SetEdges(int edges)
      {
        if (numberOfEdges == 0) 
        {
          numberOfEdges = edges;
        }
        
      }
      */

      //controllers
      public Shape(int edges)
      {
        NumberOfEdges = edges;
      }
    }
}