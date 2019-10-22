using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class WillYouMakeItTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(true, WillYouMakeIt.ZeroFuel(50, 25, 2));
            Assert.AreEqual(false, WillYouMakeIt.ZeroFuel(100, 50, 1));
        }
    }
}