using System;
using Xunit;

namespace MarsRover.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void MoveTest()
        {
            MarsRover rover = new MarsRover("3 3 E");
            rover.Move("MMRMMRMRRM");
            Assert.Equal("5 1 E", $"{rover.x} {rover.y} {rover.direction}");
        }
    }
}
