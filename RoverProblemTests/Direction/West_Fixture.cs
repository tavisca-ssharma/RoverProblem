using RoverProblem;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace RoverProblemTests.Direction
{
    class West_Fixture : IDirectionTests
    {
        void IDirectionTests.Motion_Check()
        {
            Initialisation roverDemo = new Initialisation();
            roverDemo.FacingDirection = "W";
            roverDemo.CurrX = 2;
            roverDemo.CurrY = 3;
            roverDemo.LimitX = 100;
            roverDemo.LimitY = 100;
            roverDemo.ComputePosition("M");
            Assert.Equal(1, roverDemo.CurrX);
        }
    }
}
