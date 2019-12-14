using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class WillThereBeEnoughSpaceTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(0, WillThereBeEnoughSpace.Enough(10, 5, 5));
            Assert.AreEqual(10, WillThereBeEnoughSpace.Enough(100, 60, 50));
            Assert.AreEqual(0, WillThereBeEnoughSpace.Enough(20, 5, 5));
        }
    }
}