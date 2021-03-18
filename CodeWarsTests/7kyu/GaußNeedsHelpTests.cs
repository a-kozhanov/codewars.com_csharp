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
                yield return new TestCaseData(100l).Returns(5050l);
                yield return new TestCaseData(300l).Returns(45150l);
                yield return new TestCaseData(50000l).Returns(1250025000l);
            }
        }

        [Test, TestCaseSource("testCases")]
        public long? Test(long n) => GaußNeedsHelp.RangeSum(n);
    }
}