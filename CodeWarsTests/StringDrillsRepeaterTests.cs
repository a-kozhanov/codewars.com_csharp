using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class StringDrillsRepeaterTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual("aaaaa", StringDrillsRepeater.Repeater("a", 5));
            Assert.AreEqual("NaNaNaNaNaNaNaNaNaNaNaNaNaNaNaNa", StringDrillsRepeater.Repeater("Na", 16));
            Assert.AreEqual("Wub Wub Wub Wub Wub Wub ", StringDrillsRepeater.Repeater("Wub ", 6));
        }
    }
}