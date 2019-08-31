using System.Collections.Generic;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class GreatestCommonDivisorTests
    {
        private static IEnumerable<TestCaseData> testCases
        {
            get
            {
                yield return new TestCaseData(30, 12).Returns(6);
                yield return new TestCaseData(8, 9).Returns(1);
                yield return new TestCaseData(1, 1).Returns(1);
            }
        }

        [Test, TestCaseSource("testCases")]
        public int Test(int a, int b) => GreatestCommonDivisor.Gcd(a, b);
    }
}