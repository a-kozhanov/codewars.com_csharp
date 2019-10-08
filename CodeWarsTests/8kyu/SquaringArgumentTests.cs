using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SquaringArgumentTests
    {
        [Test, Description("Sample Tests")]
        public void Test()
        {
            Assert.AreEqual(4, SquaringArgument.Square(2));
            Assert.AreEqual(100, SquaringArgument.Square(10));
        }
    }
}