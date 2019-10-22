using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class EnumerableMagic3Tests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(true, EnumerableMagic3.Include(new int[] { 1, 2, 3, 4 }, 3));
            Assert.AreEqual(false, EnumerableMagic3.Include(new int[] { 1, 2, 4, 5 }, 3));
        }
    }
}