using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class InvertValuesTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(new int[] { -1, -2, -3, -4, -5 }, InvertNumbers.InvertValues(new int[] { 1, 2, 3, 4, 5 }));
            Assert.AreEqual(new int[] { -1, 2, -3, 4, -5 }, InvertNumbers.InvertValues(new int[] { 1, -2, 3, -4, 5 }));
            Assert.AreEqual(new int[] { }, InvertNumbers.InvertValues(new int[] { }));
            Assert.AreEqual(new int[] { 0 }, InvertNumbers.InvertValues(new int[] { 0 }));
        }
    }
}