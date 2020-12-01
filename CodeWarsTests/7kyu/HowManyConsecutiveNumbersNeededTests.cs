using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class HowManyConsecutiveNumbersNeededTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(2, HowManyConsecutiveNumbersNeeded.Consecutive(new int[] {4, 8, 6}));
            Assert.AreEqual(0, HowManyConsecutiveNumbersNeeded.Consecutive(new int[] {1, 2, 3, 4}));
            Assert.AreEqual(0, HowManyConsecutiveNumbersNeeded.Consecutive(new int[] { }));
            Assert.AreEqual(0, HowManyConsecutiveNumbersNeeded.Consecutive(new int[] {1}));
        }
    }
}