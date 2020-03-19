using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SumOfBeachTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(1, SumOfBeach.SumOfABeach("SanD"));
            Assert.AreEqual(1, SumOfBeach.SumOfABeach("sunshine"));
            Assert.AreEqual(4, SumOfBeach.SumOfABeach("sunsunsunsun"));
            Assert.AreEqual(1, SumOfBeach.SumOfABeach("123FISH321"));
        }
    }
}