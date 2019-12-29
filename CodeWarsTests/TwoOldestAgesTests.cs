using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class KataTwoOldestAgesTests
    {
        [Test]
        public void Test1()
        {
            int[] result = KataTwoOldestAges.TwoOldestAges(new[] {1, 2, 10, 8});
            Assert.AreEqual(new int[] {8, 10}, result);
        }

        [Test]
        public void Test2()
        {
            int[] result = KataTwoOldestAges.TwoOldestAges(new[] {1, 5, 87, 45, 8, 8});
            Assert.AreEqual(new int[] {45, 87}, result);
        }

        [Test]
        public void Test3()
        {
            int[] result = KataTwoOldestAges.TwoOldestAges(new[] {6, 5, 83, 5, 3, 18});
            Assert.AreEqual(new int[] {18, 83}, result);
        }

        [Test]
        public void Test4()
        {
            int[] result = KataTwoOldestAges.TwoOldestAges(new[] {6, 5, 83, 83});
            Assert.AreEqual(new int[] {83, 83}, result);
        }
    }
}