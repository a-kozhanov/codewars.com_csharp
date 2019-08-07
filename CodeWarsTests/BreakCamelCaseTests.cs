using System.Collections.Generic;
using NUnit.Framework;
using CodeWars;

namespace CodeWarsTests
{
    [TestFixture]
    public class BreakCamelCaseTests
    {
        private static IEnumerable<TestCaseData> testCases
        {
            get
            {
                yield return new TestCaseData("camelCasing").Returns("camel Casing");
                yield return new TestCaseData("camelCasingTest").Returns("camel Casing Test");
            }
        }

        [Test, TestCaseSource("testCases")]
        public string Test(string str) => BreakCamelCase.breakCamelCase(str);
    }
}
