namespace ShapeWorld.Domain.Models
{
  public class Triangle : Shape
  {
    public virtual double Base {get; set;}
    public virtual double Height {get ; set;}

    public override double Perimeter()
    {
      return 0 ;
    }
    public override double Area()
    {
      return .5 * (Base * Height);
    }

    public Triangle () : base (3)
    {

    }


  }
    
}