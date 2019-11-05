using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class EvilOrOdiousTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual("It's Odious!", EvilOrOdious.Evil(1));
            Assert.AreEqual("It's Odious!", EvilOrOdious.Evil(2));
            Assert.AreEqual("It's Evil!", EvilOrOdious.Evil(3));
        }
    }
}