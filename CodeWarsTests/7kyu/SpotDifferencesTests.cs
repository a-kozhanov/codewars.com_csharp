using System.Collections.Generic;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SpotDifferencesTests
    {
        private static IEnumerable<TestCaseData> testCases
        {
            get
            {
                yield return new TestCaseData("abcdefg", "abcqetg").Returns(new List<int> {3, 5});
                yield return new TestCaseData("Hello World!", "hello world.").Returns(new List<int> {0, 6, 11});
                yield return new TestCaseData("FixedGrey", "FixedGrey").Returns(new List<int>());
            }
        }

        [Test, TestCaseSource("testCases")]
        public List<int> Test(string s1, string s2) => SpotDifferences.Spot(s1, s2);
    }
}