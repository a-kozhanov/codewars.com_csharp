using System.Collections.Generic;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class KataPowerOfTwoTests
    {
        private static IEnumerable<TestCaseData> testCases
        {
            get
            {
                yield return new TestCaseData(2).Returns(true);
                yield return new TestCaseData(4096).Returns(true);
                yield return new TestCaseData(5).Returns(false);
            }
        }

        [Test, TestCaseSource("testCases")]
        public bool SampleTest(int n) => KataPowerOfTwo.PowerOfTwo(n);
    }
}