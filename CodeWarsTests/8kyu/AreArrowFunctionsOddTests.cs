using System.Collections.Generic;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class AreArrowFunctionsOddTests
    {
        private static IEnumerable<TestCaseData> testCases
        {
            get
            {
                yield return new TestCaseData(new List<int>()).Returns(new List<int>()).SetDescription("Should handle empty list");
                yield return new TestCaseData(new List<int> { 2, 4, 6 }).Returns(new List<int>()).SetDescription("Should handle list with even numbers only");
                yield return new TestCaseData(new List<int> { 1, 3, 5 }).Returns(new List<int> { 1, 3, 5 }).SetDescription("Should handle list with odd numbers only");
                yield return new TestCaseData(new List<int> { 1, 2, 3, 4, 5, 6 }).Returns(new List<int> { 1, 3, 5 }).SetDescription("Should handle mixed list");
            }
        }

        [Test, TestCaseSource("testCases")]
        public List<int> Test(List<int> values) =>
            AreArrowFunctionsOdd.Odds(values);
    }

}