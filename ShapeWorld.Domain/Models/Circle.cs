using System;
namespace ShapeWorld.Domain.Models
{
  public class Circle : Shape
  {
    public virtual double Radius {set ; get;}
    double Pi = Math.PI;
    
    public override double Perimeter()
    {
      return 2 * (Pi * Radius);
    }

    public override double Area()
    {
      return (Pi * Radius* Radius);
    }

    public Circle () : base (int.MaxValue)
    {

    }
  }
}