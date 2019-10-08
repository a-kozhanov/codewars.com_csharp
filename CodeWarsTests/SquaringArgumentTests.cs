using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SquaringArgumentTests
    {
        [Test, Description("Sample Tests")]
        public void Test()
        {
            Assert.AreEqual(4, Kata.Square(2));
            Assert.AreEqual(100, Kata.Square(10));
        }
    }
}