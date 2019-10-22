using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class EnumerableMagicTrueForNoneTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(true, EnumerableMagicTrueForNone.None(new int[] { 1, 2, 3, 4, 5 }, v => v > 5));
            Assert.AreEqual(false, EnumerableMagicTrueForNone.None(new int[] { 1, 2, 3, 4, 5 }, v => v > 4));
        }
    }
}