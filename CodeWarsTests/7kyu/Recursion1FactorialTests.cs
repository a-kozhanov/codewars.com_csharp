using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class Recursion1FactorialTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(1, Recursion1Factorial.Factorial(0));
            Assert.AreEqual(1, Recursion1Factorial.Factorial(1));
            Assert.AreEqual(2, Recursion1Factorial.Factorial(2));
            Assert.AreEqual(6, Recursion1Factorial.Factorial(3));
        }
    }
}