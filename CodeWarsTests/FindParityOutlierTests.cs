using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class FindParityOutlierTests
    {
        [Test]
        public static void Test1()
        {
            int[] exampleTest1 = {2, 6, 8, -10, 3};
            Assert.IsTrue(3 == FindParityOutlier.Find(exampleTest1));
        }

        [Test]
        public static void Test2()
        {
            int[] exampleTest2 = {206847684, 1056521, 7, 17, 1901, 21104421, 7, 1, 35521, 1, 7781};
            Assert.IsTrue(206847684 == FindParityOutlier.Find(exampleTest2));
        }

        [Test]
        public static void Test3()
        {
            int[] exampleTest3 = {int.MaxValue, 0, 1};
            Assert.IsTrue(0 == FindParityOutlier.Find(exampleTest3));
        }
    }
}