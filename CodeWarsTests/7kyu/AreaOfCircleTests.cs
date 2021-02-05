using System;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class AreaOfCircleTests
    {
        [Test]
        public void ShouldFailNegativeNumber()
        {
            Assert.Throws<ArgumentException>(delegate { AreaOfCircle.CalculateAreaOfCircle("-123"); });
            //Assert.Throws(typeof(ArgumentException), Kata.CalculateAreaOfCircle("-123"));
        }

        [Test]
        public void ShouldFailAlphaNumeric()
        {
            Assert.Throws<ArgumentException>(delegate { AreaOfCircle.CalculateAreaOfCircle("number"); });
        }

        [Test]
        public void ShouldPass1()
        {
            Assert.AreEqual(5881.25, AreaOfCircle.CalculateAreaOfCircle("43.2673"));
        }
    }
}