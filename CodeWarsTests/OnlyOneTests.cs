using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class KataOnlyOneTests
    {
        [Test]
        public void BasicTest()
        {
            Assert.AreEqual(true, KataOnlyOne.OnlyOne(true, false));
        }
    }
}