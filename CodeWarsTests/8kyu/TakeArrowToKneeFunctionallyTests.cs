using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class TakeArrowToKneeFunctionallyTests
    {
        [Test]
        public static void FixedTests()
        {
            Assert.AreEqual("Test", TakeArrowToKneeFunctionally.ArrowFunc(new int[] { 84, 101, 115, 116 }), "");
        }
    }
}