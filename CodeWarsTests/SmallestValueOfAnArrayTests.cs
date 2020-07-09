using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SmallestValueOfAnArrayTests
    {
        [Test]
        public void Test_54321_value()
        {
            Assert.AreEqual(1, SmallestValueOfAnArray.FindSmallest(new int[] {5, 4, 3, 2, 1}, "value"));
        }

        [Test]
        public void Test_54321_index()
        {
            Assert.AreEqual(4, SmallestValueOfAnArray.FindSmallest(new int[] {5, 4, 3, 2, 1}, "index"));
        }
    }
}