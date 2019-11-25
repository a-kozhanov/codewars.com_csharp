using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class AlanPartridgeIIAppleTurnoverTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual("It's hotter than the sun!!", AlanPartridgeIIAppleTurnover.Apple("50"));
            Assert.AreEqual("Help yourself to a honeycomb Yorkie for the glovebox.", AlanPartridgeIIAppleTurnover.Apple(4));
        }
    }
}