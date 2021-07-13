using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class CompletePattern3HorizontalImageOf2Tests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual("1", CompletePattern3HorizontalImageOf2.Pattern(1));
            Assert.AreEqual("2\n21", CompletePattern3HorizontalImageOf2.Pattern(2));
            Assert.AreEqual("5\n54\n543\n5432\n54321", CompletePattern3HorizontalImageOf2.Pattern(5));
        }
    }
}