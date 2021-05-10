using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class FoldingYourWayToMoonTests
    {
        private static object[] Basic_Test_Cases = new object[]
        {
            new object[] {384000000, 42},
        };

        [Test, TestCaseSource(typeof(FoldingYourWayToMoonTests), "Basic_Test_Cases")]
        public void Basic_Test(double distance, int? expected)
        {
            Assert.AreEqual(expected, FoldingYourWayToMoon.FoldTo(distance));
        }
    }
}