using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class EverythingIsEvenTests
    {
        [Test]
        public void SimpleTests()
        {
            Assert.AreEqual(2, EverythingIsEven.EnsureEven(1));
            Assert.AreEqual(2, EverythingIsEven.EnsureEven(1.356));
        }
    }
}