using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class CanWeDivideItTests
    {
        [Test]
        public void BasicTest()
        {
            Assert.AreEqual(true, CanWeDivideIt.is_divide_by(-12, 2, 6));
            Assert.AreEqual(false, CanWeDivideIt.is_divide_by(-12, 2, -5));
            Assert.AreEqual(false, CanWeDivideIt.is_divide_by(-45, 1, 6));
            Assert.AreEqual(true, CanWeDivideIt.is_divide_by(45, 5, 15));
            Assert.AreEqual(true, CanWeDivideIt.is_divide_by(4, 1, 4));
            Assert.AreEqual(true, CanWeDivideIt.is_divide_by(15, -5, 3));
        }
    }
}