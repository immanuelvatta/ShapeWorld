using ShapeWorld.Domain.Models;
using Xunit;

namespace ShapeWorld.Testing
{
  public class RectangleTests
  {
    [Fact]
    public void Test_Edges()
    {
      //arrange
      //var = lazy inference (1st value you give is going to be what it uses)
      //use if the type is obvious/known
      var rectangle = new Rectangle();
      var expected = 4;

      //act
      var actual = rectangle.NumberOfEdges;

      //assert
      Assert.True(expected == actual);
    }
  }
}