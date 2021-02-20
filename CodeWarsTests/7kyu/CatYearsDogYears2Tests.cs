using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class CatYearsDogYears2Tests
    {
        [Test]
        public void One()
        {
            Assert.AreEqual((1, 1), CatYearsDogYears2.OwnedCatAndDog(15, 15));
        }

        [Test]
        public void Two()
        {
            Assert.AreEqual((2, 2), CatYearsDogYears2.OwnedCatAndDog(24, 24));
        }

        [Test]
        public void Ten()
        {
            Assert.AreEqual((10, 10), CatYearsDogYears2.OwnedCatAndDog(56, 64));
        }
    }
}