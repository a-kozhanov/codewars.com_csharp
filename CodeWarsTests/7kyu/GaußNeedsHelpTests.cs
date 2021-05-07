using System.Collections.Generic;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class GaußNeedsHelpTests
    {
        private static IEnumerable<TestCaseData> testCases
        {
            get
            {
                yield return new TestCaseData(100L).Returns(5050L);
                yield return new TestCaseData(300L).Returns(45150L);
                yield return new TestCaseData(50000L).Returns(1250025000L);
            }
        }

        [Test, TestCaseSource("testCases")]
        public long? Test(long n) => GaußNeedsHelp.RangeSum(n);
    }
}