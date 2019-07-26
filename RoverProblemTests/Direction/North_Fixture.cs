using RoverProblem;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace RoverProblemTests.Direction
{
    class North_Fixture : IDirectionTests
    {
        void IDirectionTests.Motion_Check()
        {
            Initialisation roverDemo = new Initialisation();
            roverDemo.FacingDirection = "N";
            roverDemo.CurrX = 2;
            roverDemo.CurrY = 3;
            roverDemo.LimitX = 100;
            roverDemo.LimitY = 100;
            roverDemo.ComputePosition("M");
            Assert.Equal(4, roverDemo.CurrY);
            throw new NotImplementedException();
        }
    }
}
