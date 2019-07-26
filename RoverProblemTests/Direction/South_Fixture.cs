using RoverProblem;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace RoverProblemTests.Direction
{
    class South_Fixture : IDirectionTests
    {
        void IDirectionTests.Motion_Check()
        {
            Rover roverDemo = new Rover();
            roverDemo.FacingDirection = "S";
            roverDemo.CurrX = 2;
            roverDemo.CurrY = 3;
            roverDemo.LimitX = 100;
            roverDemo.LimitY = 100;
            roverDemo.ComputePosition("M");
            Assert.Equal(2, roverDemo.CurrY);
        }
    }
}
