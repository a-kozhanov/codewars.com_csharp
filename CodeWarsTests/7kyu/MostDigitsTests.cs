using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class MostDigitsTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(100, MostDigits.FindLongest(new int[] {1, 10, 100}));
            Assert.AreEqual(9000, MostDigits.FindLongest(new int[] {9000, 8, 800}));
            Assert.AreEqual(900, MostDigits.FindLongest(new int[] {8, 900, 500}));
        }
    }
}