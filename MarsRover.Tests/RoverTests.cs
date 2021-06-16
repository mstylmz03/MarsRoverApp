using Microsoft.VisualStudio.TestTools.UnitTesting;
using MarsRover.Entity;

namespace MarsRover.Tests
{
    [TestClass]
    public class RoverTests
    {
        [TestMethod]
        public void Rover1MoveTest()
        {
            Rover rover = new Rover("3 3 E");
            rover.Move("MMRMMRMRRM");
            Assert.AreEqual("5 1 E",rover.x + " " + rover.y + " " + rover.direction);
        }
        [TestMethod]
        public void Rover2MoveTest()
        {
            Rover rover = new Rover("1 2 N");
            rover.Move("LMLMLMLMM");
            Assert.AreEqual("1 3 N",rover.x + " " + rover.y + " " + rover.direction);
        }


    }
}
