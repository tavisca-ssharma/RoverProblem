using Xunit;
using RoverProblem;

namespace RoverProblemTests
{
    public class PositionTests
    {
        [Fact]
        public void Constructor_and_Getter_Check()
        {
            Initialisation roverDemo = new Initialisation();
            Assert.Equal(0, roverDemo.LimitX);
            Assert.Equal(0, roverDemo.LimitY);
            Assert.Equal(0, roverDemo.CurrX);
            Assert.Equal(0, roverDemo.CurrY);
            Assert.Equal("N", roverDemo.FacingDirection);
        }

        [Fact]
        public void Setter_Check()
        {
            Initialisation roverDemo = new Initialisation();
            roverDemo.LimitX = 180;
            roverDemo.LimitY = 400;
            roverDemo.FacingDirection = "S";
            roverDemo.CurrX = 0;
            roverDemo.CurrY = 0;
            Assert.Equal(180, roverDemo.LimitX);
            Assert.Equal(400, roverDemo.LimitY);
            Assert.Equal(0, roverDemo.CurrX);
            Assert.Equal(0, roverDemo.CurrY);
            Assert.Equal("S", roverDemo.FacingDirection);
        }
    }
}
