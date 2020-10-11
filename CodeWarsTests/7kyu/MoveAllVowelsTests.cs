using System.Collections.Generic;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class MoveAllVowelsTests
    {
        private static IEnumerable<TestCaseData> testCases
        {
            get
            {
                yield return new TestCaseData("day").Returns("dya");
                yield return new TestCaseData("apple").Returns("pplae");
                yield return new TestCaseData("peace").Returns("pceae");
                yield return new TestCaseData("maker").Returns("mkrae");
            }
        }

        [Test, TestCaseSource("testCases")]
        public string Test(string input) => MoveAllVowels.MoveVowel(input);
    }
}