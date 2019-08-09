namespace ShapeWorld.Domain.Interfaces
{
  public interface IThreeD
  {
    double Height { get; set; }
    //everything inside of an interface must be public
    // all the members of interface is public
    // can be implicit or explicit
    // most of the object is implicit

    double Volume ();

  }
}