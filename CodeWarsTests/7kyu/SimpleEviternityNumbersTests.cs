using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SimpleEviternityNumbersTests
    {
        [Test]
        public void ExampleTests()
        {
            Assert.AreEqual(4, SimpleEviternityNumbers.solve(1, 100));
            Assert.AreEqual(14, SimpleEviternityNumbers.solve(1, 1000));
            Assert.AreEqual(37, SimpleEviternityNumbers.solve(1, 10000));
            Assert.AreEqual(103, SimpleEviternityNumbers.solve(1, 100000));
        }
    }
}