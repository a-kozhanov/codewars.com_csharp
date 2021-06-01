using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class KataRandomNumberGeneratorTests
    {
        [Test]
        public void FirstTest()
        {
            KataRandomNumberGenerator kata1 = new KataRandomNumberGenerator();
            KataRandomNumberGenerator kata2 = new KataRandomNumberGenerator();
            Assert.AreNotEqual(kata1.GenerateRandomNumber(), kata2.GenerateRandomNumber());
        }
    }
}