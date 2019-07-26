using RoverProblem;
using Xunit;

namespace RoverProblemTests
{
    public class RotationTests
    {
        [Fact]
        public void Simple_Left_Rotation_Check()
        {
            Initialisation roverDemo = new Initialisation();
            roverDemo.FacingDirection = "E";
            roverDemo.ComputePosition("L");
            Assert.Equal("N", roverDemo.FacingDirection);
        }

        [Fact]
        public void Simple_Right_Rotation_Check()
        {
            Initialisation roverDemo = new Initialisation();
            roverDemo.FacingDirection = "E";
            roverDemo.ComputePosition("R");
            Assert.Equal("S", roverDemo.FacingDirection);
        }
    }
}
