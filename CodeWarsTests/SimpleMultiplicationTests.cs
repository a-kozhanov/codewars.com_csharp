using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SimpleMultiplicationTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(9, SimpleMultiplication.Multiply(1), "Should return given argument times nine");
            Assert.AreEqual(16, SimpleMultiplication.Multiply(2), "Should return given argument times eight");
            Assert.AreEqual(64, SimpleMultiplication.Multiply(8), "Should return given argument times eight");
            Assert.AreEqual(32, SimpleMultiplication.Multiply(4), "Should return given argument times eight");
            Assert.AreEqual(45, SimpleMultiplication.Multiply(5), "Should return given argument times nine");
        }
    }
}