using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class GetPlanetNameByIDTests
    {
        [Test]
        public void Test()
        {
            Assert.AreEqual("Venus", KataGetPlanetNameByID.GetPlanetName(2));
            Assert.AreEqual("Jupiter", KataGetPlanetNameByID.GetPlanetName(5));
        }
    }
}