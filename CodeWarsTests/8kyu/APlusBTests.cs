using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class APlusBTests
    {
        [Test]
        public void testSum()
        {
            byte a = 1;
            byte b = 2;
            Assert.AreEqual(3, APlusB.sum(a, b));
        }
    }
}
