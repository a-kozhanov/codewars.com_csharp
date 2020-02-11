using System.Collections.Generic;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    public class NumbersInStringsTests
    {
        private static IEnumerable<TestCaseData> testCases
        {
            get
            {
                yield return new TestCaseData("gh12cdy695m1").Returns(695)
                    .SetDescription("Arguments: (\"gh12cdy695m1\")\n      Expected: 695");
                yield return new TestCaseData("2ti9iei7qhr5").Returns(9)
                    .SetDescription("Arguments: (\"2ti9iei7qhr5\")\n      Expected: 9");
                yield return new TestCaseData("vih61w8oohj5").Returns(61)
                    .SetDescription("Arguments: (\"vih61w8oohj5\")\n      Expected: 61");
                yield return new TestCaseData("f7g42g16hcu5").Returns(42)
                    .SetDescription("Arguments: (\"f7g42g16hcu5\")\n      Expected: 42");
                yield return new TestCaseData("lu1j8qbbb85").Returns(85)
                    .SetDescription("Arguments: (\"lu1j8qbbb85\")\n      Expected: 85");
            }
        }

        [Test, TestCaseSource("testCases")]
        public int Test(string s) =>
            NumbersInStrings.Solve(s);
    }
}