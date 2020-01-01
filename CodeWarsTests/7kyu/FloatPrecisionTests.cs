using System.Collections.Generic;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class FloatPrecisionTests
    {
        private static IEnumerable<TestCaseData> testCases
        {
            get
            {
                yield return new TestCaseData(2.34).Returns(2.34);
                yield return new TestCaseData(5.678).Returns(5.68);
            }
        }

        [Test, TestCaseSource("testCases")]
        public double FixedTest(double n) => FloatPrecision.Round(n);
    }
}