using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class FactorialFactoryTests
    {
        [Test]
        public void Test1()
        {
            // Don't forget the special cases!
            Assert.AreEqual(FactorialFactory.Factorial(1), 1);
            Assert.AreEqual(FactorialFactory.Factorial(5), 120);
        }
    }
}