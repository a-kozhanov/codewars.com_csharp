using System;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class FunctionsOfIntegersOnCartesianPlaneTests
    {
        Random randomGenerator = new Random();

        [Test]
        public void Test01()
        {
            Assert.AreEqual(55, FunctionsOfIntegersOnCartesianPlane.sumin(5));
        }

        [Test]
        public void Test04()
        {
            Assert.AreEqual(372, FunctionsOfIntegersOnCartesianPlane.sumax(8));
        }

        [Test]
        public void Test05()
        {
            Assert.AreEqual(576, FunctionsOfIntegersOnCartesianPlane.sumsum(8));
        }
    }
}