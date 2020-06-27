using System.Collections.Generic;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class WeHaveLiftoffTests
    {
        private static IEnumerable<TestCaseData> testCases
        {
            get
            {
                yield return new TestCaseData(new List<int> {2, 8, 10, 9, 1, 3, 4, 7, 6, 5}).Returns(
                    "10 9 8 7 6 5 4 3 2 1 liftoff!");
            }
        }

        [Test, TestCaseSource("testCases")]
        public string Test(List<int> instructions) =>
            WeHaveLiftoff.Liftoff(instructions);
    }
}