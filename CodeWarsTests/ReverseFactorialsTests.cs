using System.Collections.Generic;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class ReverseFactorialsTests
    {
        private static IEnumerable<TestCaseData> testCases
        {
            get
            {
                yield return new TestCaseData(120).Returns("5!").SetDescription("120 should return \"5!\"");
                yield return new TestCaseData(3628800).Returns("10!").SetDescription("3628800 should return \"10!\"");
                yield return new TestCaseData(150).Returns("None").SetDescription("150 should return \"None\"");
            }
        }

        [Test, TestCaseSource("testCases")]
        public string Test(long num) => ReverseFactorials.ReverseFactorial(num);
    }
}