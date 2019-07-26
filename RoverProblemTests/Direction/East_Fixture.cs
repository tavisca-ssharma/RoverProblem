using RoverProblem;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace RoverProblemTests.Direction
{
    class East_Fxture : IDirectionTests
    {
        void IDirectionTests.Motion_Check()
        {
            Initialisation roverDemo = new Initialisation();
            roverDemo.FacingDirection = "E";
            roverDemo.CurrX = 2;
            roverDemo.CurrY = 3;
            roverDemo.LimitX = 100;
            roverDemo.LimitY = 100;
            roverDemo.ComputePosition("M");
            Assert.Equal(3, roverDemo.CurrX);
            throw new NotImplementedException();
        }
    }
}
