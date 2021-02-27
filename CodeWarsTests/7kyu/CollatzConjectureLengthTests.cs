using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class CollatzConjectureLengthTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(8, CollatzConjectureLength.Collatz(20));
            Assert.AreEqual(18, CollatzConjectureLength.Collatz(15));
        }
    }
}