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

        [Test]
        public void Test_809_index()
        {
            Assert.AreEqual(1, SmallestValueOfAnArray.FindSmallest(new int[] {8, 0, 9}, "index"));
        }

        [Test]
        public void Test_809_value()
        {
            Assert.AreEqual(0, SmallestValueOfAnArray.FindSmallest(new int[] {8, 0, 9}, "value"));
        }

        [Test]
        public void Test_110011_index()
        {
            Assert.AreEqual(2, SmallestValueOfAnArray.FindSmallest(new int[] {1, 1, 0, 0, 1, 1}, "index"));
        }

        [Test]
        public void Test_110011_value()
        {
            Assert.AreEqual(0, SmallestValueOfAnArray.FindSmallest(new int[] {1, 1, 0, 0, 1, 1}, "value"));
        }
    }
}