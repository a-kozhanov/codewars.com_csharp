using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class ArithmeticTests
    {
        [Test]
        public void ExampleTests()
        {
            Assert.AreEqual(3, Arithmetic.arithmetic(1, 2, "add"));
            Assert.AreEqual(6, Arithmetic.arithmetic(8, 2, "subtract"));
            Assert.AreEqual(10, Arithmetic.arithmetic(5, 2, "multiply"));
            Assert.AreEqual(4, Arithmetic.arithmetic(8, 2, "divide"));
        }
    }
}