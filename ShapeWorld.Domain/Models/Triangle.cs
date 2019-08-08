namespace ShapeWorld.Domain.Models
{
  class Triangle : Shape
  {
    public virtual double Base {get; set;}
    public virtual double Height {get ; set;}

    public override double Perimeter()
    {
      return 0 ;
    }
    public override double Area()
    {
      return (Base * Height)/2;
    }

    public Triangle () : base (3)
    {

    }


  }
    
}