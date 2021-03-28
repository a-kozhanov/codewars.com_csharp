using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class VasyaAndPlatesTests
    {
        [Test]
        public void Test1()
        {
            int b = 1;
            int p = 1;
            int[] dishes = new int[] {1, 2, 1};
            Assert.AreEqual(1, VasyaAndPlates.CountClean(b, p, dishes));
        }

        [Test]
        public void Test2()
        {
            int b = 3;
            int p = 1;
            int[] dishes = new int[] {1, 1, 1, 1};
            Assert.AreEqual(1, VasyaAndPlates.CountClean(b, p, dishes));
        }
    }
}