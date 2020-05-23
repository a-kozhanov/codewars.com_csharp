using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SimpleFun38HouseOfCatsTests
    {
        [Test]
        public void BasicTests()
        {
            var kata = new SimpleFun38HouseOfCats();

            Assert.AreEqual(new int[] {1, 3}, kata.HouseOfCats(6));

            Assert.AreEqual(new int[] {1}, kata.HouseOfCats(2));

            Assert.AreEqual(new int[] {0, 2, 4}, kata.HouseOfCats(8));

            Assert.AreEqual(new int[] {0, 2}, kata.HouseOfCats(4));

            Assert.AreEqual(new int[] {0, 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22}, kata.HouseOfCats(44));
        }
    }
}