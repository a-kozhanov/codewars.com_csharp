using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class KataMinMinMaxTests
    {
        private static object[] Basic_Test_Cases = new object[]
        {
            new object[] {new int[] {-1, 4, 5, -23, 24}, new int[] {-23, -22, 24}},
            new object[] {new int[] {1, 3, -3, -2, 8, -1}, new int[] {-3, 0, 8}},
            new object[] {new int[] {2, -4, 8, -5, 9, 7}, new int[] {-5, -3, 9}},
        };

        [Test, TestCaseSource(typeof(KataMinMinMaxTests), "Basic_Test_Cases")]
        public void Basic_Test(int[] test, int[] expected)
        {
            Assert.AreEqual(expected, KataMinMinMax.MinMinMax(test));
        }
    }
}