using System.Collections.Generic;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class IndexedCapitalizationTests
    {
        private static IEnumerable<TestCaseData> testCases
        {
            get
            {
                yield return new TestCaseData("abcdef", new List<int> {1, 2, 5}).Returns("aBCdeF");
                yield return new TestCaseData("abcdef", new List<int> {1, 2, 5, 100}).Returns("aBCdeF");
                yield return new TestCaseData("abcdef", new List<int> {1, 100, 2, 5}).Returns("aBCdeF");
                yield return new TestCaseData("codewars", new List<int> {1, 3, 5, 50}).Returns("cOdEwArs");
                yield return new TestCaseData("abracadabra", new List<int> {2, 6, 9, 10}).Returns("abRacaDabRA");
                yield return new TestCaseData("codewarriors", new List<int> {5}).Returns("codewArriors");
                yield return new TestCaseData("indexinglessons", new List<int> {0}).Returns("Indexinglessons");
            }
        }

        [Test, TestCaseSource("testCases")]
        public string Test(string s, List<int> idxs) =>
            IndexedCapitalization.Capitalize(s, idxs);
    }
}