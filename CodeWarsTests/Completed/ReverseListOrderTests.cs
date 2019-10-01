using System.Collections.Generic;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class ReverseListOrderTests
    {
        private static IEnumerable<TestCaseData> testCases
        {
            get
            {
                yield return new TestCaseData(new List<int> { 1, 2, 3, 4 }).Returns(new List<int> { 4, 3, 2, 1 });
                yield return new TestCaseData(new List<int> { 3, 1, 5, 4 }).Returns(new List<int> { 4, 5, 1, 3 });
                yield return new TestCaseData(new List<int> { 3, 6, 9, 2 }).Returns(new List<int> { 2, 9, 6, 3 });
            }
        }

        [Test, TestCaseSource("testCases")]
        public List<int> SampleTest(List<int> list) => ReverseListOrder.ReverseList(list);
    }
}
