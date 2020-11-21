using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class LargestPairSumInArrayTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(-16, LargestPairSumInArray.LargestPairSum(new int[] {-8, -8, -16, -18, -19}));
            Assert.AreEqual(0, LargestPairSumInArray.LargestPairSum(new int[] {-100, -29, -24, -19, 19}));
            Assert.AreEqual(10, LargestPairSumInArray.LargestPairSum(new int[] {1, 2, 3, 4, 6, -1, 2}));
            Assert.AreEqual(42, LargestPairSumInArray.LargestPairSum(new int[] {10, 14, 2, 23, 19}));
        }
    }
}