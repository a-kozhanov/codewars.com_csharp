using System.Collections.Generic;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class KataNegationOfValueTests
    {
        private static IEnumerable<TestCaseData> testCases
        {
            get
            {
                yield return new TestCaseData("!", false).Returns(true).SetDescription("Basic Test");
                yield return new TestCaseData("!", true).Returns(false).SetDescription("Basic Test");
                yield return new TestCaseData("!!!", false).Returns(true).SetDescription("Basic Test");
            }
        }

        [Test, TestCaseSource("testCases")]
        public bool Test(string str, bool value) => KataNegationOfValue.NegationValue(str, value);
    }
}