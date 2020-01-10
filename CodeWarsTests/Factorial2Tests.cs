using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class Factorial2Tests
    {
        [Test]
        public void FactorialOf0ShouldBe1()
        {
            Assert.AreEqual(1, Factorial2.Factorial(0));
        }

        [Test]
        public void FactorialOf1ShouldBe1()
        {
            Assert.AreEqual(1, Factorial2.Factorial(1));
        }

        [Test]
        public void FactorialOf2ShouldBe2()
        {
            Assert.AreEqual(2, Factorial2.Factorial(2));
        }

        [Test]
        public void FactorialOf3ShouldBe6()
        {
            Assert.AreEqual(6, Factorial2.Factorial(3));
        }
    }
}