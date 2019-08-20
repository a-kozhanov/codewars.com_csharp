using NUnit.Framework;
using CodeWars;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace CodeWarsTests
{
    [TestFixture]
    public class BasicMathematicalOperationsTests
    {
        [Test]
        public void StaticTests()
        {
            Assert.AreEqual(BasicMathematicalOperations.basicOp('+', 4, 7), 11);
            Assert.AreEqual(BasicMathematicalOperations.basicOp('-', 15, 18), -3);
            Assert.AreEqual(BasicMathematicalOperations.basicOp('*', 5, 5), 25);
            Assert.AreEqual(BasicMathematicalOperations.basicOp('/', 49, 7), 7);
        }
    }
}