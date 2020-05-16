using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class OddEvenStringSortTests
    {
        private static object[] testCases = new object[]
        {
            new object[] {"CodeWars", "CdWr oeas"},
            new object[] {"YCOLUE'VREER", "YOU'RE CLEVER"},
        };

        [Test, TestCaseSource("testCases")]
        public void Test(string s, string expected) => Assert.AreEqual(expected, OddEvenStringSort.SortMyString(s));
    }
}