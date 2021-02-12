using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class BoiledEggsTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(0, BoiledEggs.CookingTime(0), "0 eggs");
            Assert.AreEqual(5, BoiledEggs.CookingTime(5), "5 eggs");
            Assert.AreEqual(10, BoiledEggs.CookingTime(10), "10 eggs");
        }
    }
}