using CodeWars;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class FactorialTests
    {
        [Test]
        public void Tests()
        {
            Assert.AreEqual(1, Factorial.factorial(0));
            Assert.AreEqual(1, Factorial.factorial(1));
            Assert.AreEqual(2, Factorial.factorial(2));
            Assert.AreEqual(6, Factorial.factorial(3));
            Assert.AreEqual(24, Factorial.factorial(4));
            Assert.AreEqual(120, Factorial.factorial(5));
        }
    }
}