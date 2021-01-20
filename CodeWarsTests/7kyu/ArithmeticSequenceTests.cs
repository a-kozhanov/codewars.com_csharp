using System.Collections.Generic;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class ArithmeticSequenceTests
    {
        private static IEnumerable<TestCaseData> testCases
        {
            get
            {
                yield return new TestCaseData(1, 2, 3).Returns(7);
                yield return new TestCaseData(2, 2, 2).Returns(6);
                yield return new TestCaseData(-50, 10, 20).Returns(150);
            }
        }

        [Test, TestCaseSource("testCases")]
        public int Test(int first, int n, int c) => ArithmeticSequence.Nthterm(first, n, c);
    }
}