using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class KeepUpHoopTests
    {
        [Test]
        public static void FixedTest()
        {
            Assert.AreEqual("Keep at it until you get it", KeepUpHoop.HoopCount(6), "Should work for 6");
            Assert.AreEqual("Great, now move on to tricks", KeepUpHoop.HoopCount(22), "Should work for 22");
        }
    }
}