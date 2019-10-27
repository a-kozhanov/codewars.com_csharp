using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class ShortLongShortTests
    {
        [Test]
        public void BasicTest()
        {
            Assert.AreEqual("1221", ShortLongShort.Solution("1", "22"));
            Assert.AreEqual("1221", ShortLongShort.Solution("22", "1"));
            Assert.AreEqual("12321", ShortLongShort.Solution("232", "1"));
            Assert.AreEqual("232", ShortLongShort.Solution("232", ""));
            Assert.AreEqual("2322132232", ShortLongShort.Solution("232", "2132"));
        }
    }
}