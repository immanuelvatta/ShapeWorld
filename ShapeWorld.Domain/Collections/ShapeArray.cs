using System.Collections.Generic;
using ShapeWorld.Domain.Models;
using System.Linq;
using System;

namespace ShapeWorld.Domain.Collections
{
  public class ShapeArray
  {
    public void DimensionalArray()
    {
      //1-D array (1 dimensional array)
      //arrays start at 0 becase of the offset from the origin and not position of the content
      Shape[] shaped = new Shape[10]; // empty array of shape that contain 10 shapes
      Shape[] shaped2 = new Shape[]{new Square()}; // array of shape that contain square


      // 2-D array ( 2 dimensional array matrices and tables)
      Shape[,] shaped3 = new Shape[2,2];
      Shape[,] shaped4 = new Shape[,]{{new Square(),new Square()},{new Cube(),new Triangle()}};
      /* you can rewrite the line 17 like this as well
      Shape[,] shaped4 = new Shape[,]
      {
        {new Square(),new Square()},
        {new Cube(),new Triangle()}
      };
        */

      // 3-D array (3 dimensional array )
      Shape[,,] shaped5 = new Shape [3,3,3];
      Shape[,,] shaped6 = new Shape [,,]
      {
        {
          {new Square(), new Square(), new Square ()},
          {new Square(), new Square(), new Square ()},
          {new Square(), new Square(), new Square ()}
        },
        {
          {new Square(), new Square(), new Square ()},
          {new Square(), new Square(), new Square ()},
          {new Square(), new Square(), new Square ()}
        },
        {
          {new Square(), new Square(), new Square ()},
          {new Square(), new Square(), new Square ()},
          {new Square(), new Square(), new Square ()}
        }
      };

      //READ
      System.Console.WriteLine(shaped2[0]);
      System.Console.WriteLine(shaped4[1,0]);
      System.Console.WriteLine(shaped6[1,0,2]);

      //WRITE
      shaped2[0] = new Circle();
      shaped4[1,0] = new Cube();
      shaped6[1,0,2] = new Rectangle();
      //Jagged Array

      Shape[][] shaped7 = new Shape[10][];
      Shape[][] shaped8 = new Shape[][]
      {
        new Rectangle[10],
        new Circle[]{new Circle(), new Circle()}
        // if you dont specify it will be new Shape
        //new []{new Rectangle(), new Triangle()} 
       
      };
      System.Console.WriteLine(shaped8[1][1]);
    
    }
    public void MyList()
    {
      //list have built in search capabilities that arrays dont
      //lists are dynamic and versatile
      List<Shape> shaped = new List<Shape>();
      List<Shape> shaped2 = new List<Shape> {new Cube(), new Cube()};
      
      List<Shape[][,,]> shaped3 = new List<Shape[][,,]>();
      List<Shape[][,,]> shaped4 = new List<Shape[][,,]>{new Shape[5][,,]};

      
      //READING a List
      
      //if you only add to the list, it works as an array
      //however if you add , remove, etc it is poosible the order of the last one might not be at the end.
      //so ordering is not guaranteed
      System.Console.WriteLine(shaped2);
      //predicate function (method without techinal signature)
      //fat arrow ( => ) given a variable, the set variable matches the condition, 
      //if it does then give the result else carry on
      System.Console.WriteLine(shaped2.Find(e => e.NumberOfEdges == 4));
      //find index can also use predicate
      System.Console.WriteLine(shaped2.FindIndex(e => e.NumberOfEdges == 4));
      //once you add System.Linq; you can do this
      System.Console.WriteLine(shaped2.FirstOrDefault(e => e.NumberOfEdges == 4));

      //WRITING a List
      try
      {
        shaped2[100] = new Rectangle();    
      }
      //not handling it at all (there is an error but not getting handled)
      //whoever calls the programs' job is to fix the problem
      catch(NullReferenceException)
      {
        throw;
      }
      //fully handle (recover from the error)
      catch (ArgumentOutOfRangeException)
      {
        shaped2.Add(new Rectangle());
      }
      //throw exception acknowledge the error but will not fix the problem
      //interrupts the signal
      catch (Exception ex)
      {
        throw ex;
      }
      finally
      //finally only runs if the code does not break the hardware 
      //but will always run if the application is only affected
      {
        GC.Collect();
        System.Console.WriteLine("it is final");
      }
      //or let the list decide where to put it where it deems the fastest
      shaped2.Add(new Triangle());
      //list has the ability to do range
      shaped2.AddRange(shaped2);


      //REMOVE
      shaped2.Remove(new Cube());
    
    }

    public void MyDictionary()
    {
      //dictionlary contrary to a list will have 2 types associated with it
      //guid = alpha numeric
      //Dictionary<Guid, Shape> shaped = new Dictionary<Guid,Shape>();
      Dictionary<string, Shape> shaped = new Dictionary<string, Shape>();
      Dictionary<string, Shape> shaped3 = new Dictionary<string, Shape>
      {
        {"Square", new Square()}
      };
      Dictionary<string,List<Shape>> shaped2 = new Dictionary<string, List<Shape>>
      {
        {"square", new List<Shape>()}

      };

      //READING a Dictionary
      System.Console.WriteLine(shaped2["square"]);
      shaped2.Select(d => d.Key == "square");

      //WRITE
      shaped2["square"] = new List<Shape>();

      try
      {
        shaped2.Add("square", new List<Shape>());
      }
      catch(Exception)
      {
        shaped2["squared"] = new List<Shape>();
      }

    }
    //example of a predicate function
    //continue search till you find everything then return
    /*
    public void Search(object o, List<object> 1)
    {
      1.ForEach(o1 in 1)
      {
        if (o.Equals (o1))
        {
          yield return o1;
        }
      }
    }
    */
  }
}