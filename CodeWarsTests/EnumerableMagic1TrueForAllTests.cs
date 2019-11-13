using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class EnumerableMagic1TrueForAllTests
    {
        [Test]
        public void BasicTest()
        {
            Assert.AreEqual(true, EnumerableMagic1TrueForAll.All(new int[] { 1, 2, 3, 4, 5 }, v => v < 9));
            Assert.AreEqual(false, EnumerableMagic1TrueForAll.All(new int[] { 1, 2, 3, 4, 5 }, v => v > 9));
        }
    }
}