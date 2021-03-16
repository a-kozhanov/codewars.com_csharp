using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class HandsUpTests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(new int[] {2, 1, 0}, HandsUp.GetPositions(5));
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(new int[] {0, 2, 0}, HandsUp.GetPositions(33));
        }

        [Test]
        public void Test3()
        {
            Assert.AreEqual(new int[] {0, 0, 0}, HandsUp.GetPositions(0));
        }
    }
}