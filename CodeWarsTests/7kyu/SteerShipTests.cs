using System;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SteerShipTests
    {
        [Test]
        public void ExampleTestCases()
        {
            Assert.AreEqual("R: 45", SteerShip.Steer(1, 1));
            Assert.AreEqual("R: 90", SteerShip.Steer(1, 0));
            Assert.AreEqual("L: 30", SteerShip.Steer(-1, Math.Sqrt(3)));

            Assert.IsTrue(SteerShip.Steer(0, 1) == "R: 0" || SteerShip.Steer(0, 1) == "L: 0");
            Assert.IsTrue(SteerShip.Steer(0, -1) == "R: 180" || SteerShip.Steer(0, -1) == "L: 180");
        }
    }
}