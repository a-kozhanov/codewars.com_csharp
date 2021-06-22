using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class EnumerableMagic5TrueForJustOneTests
    {
        [Test]
        public void BasicTest()
        {
            Assert.AreEqual(true, EnumerableMagic5TrueForJustOne.One(new int[] {1, 2, 3, 4, 5}, v => v < 2));
            Assert.AreEqual(false, EnumerableMagic5TrueForJustOne.One(new int[] {1, 2, 3, 4, 5}, v => v % 2 != 0));
            Assert.AreEqual(false, EnumerableMagic5TrueForJustOne.One(new int[] {1, 2, 3, 4, 5}, v => v > 5));
        }
    }
}