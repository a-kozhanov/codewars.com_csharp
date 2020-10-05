using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class GetIntegersBetweenTwoNumbersTests
    {
        private static object[] Basic_Test_Cases = new object[]
        {
            new object[] {2, 9, new int[] {3, 4, 5, 6, 7, 8}},
            new object[] {6, 8, new int[] {7}},
            new object[] {210, 210, new int[] { }},
        };

        [Test, TestCaseSource(typeof(GetIntegersBetweenTwoNumbersTests), "Basic_Test_Cases")]
        public void Basic_Test(int startNum, int endNum, int[] expected)
        {
            Assert.AreEqual(expected, GetIntegersBetweenTwoNumbers.Range(startNum, endNum));
        }

        // Note: Random tests output total user code runtime under its section.
    }
}