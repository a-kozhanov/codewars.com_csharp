using System.Collections.Generic;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class YouCantCodeUnderPressureTests
    {
        [TestFixture]
        public class CodeWarsTest
        {
            private static IEnumerable<TestCaseData> testCases
            {
                get
                {
                    yield return new TestCaseData(2).Returns(4);
                    yield return new TestCaseData(4).Returns(8);
                    yield return new TestCaseData(-10).Returns(-20);
                    yield return new TestCaseData(0).Returns(0);
                    yield return new TestCaseData(100).Returns(200);
                }
            }

            [Test, TestCaseSource("testCases")]
            public int Test(int n) => YouCantCodeUnderPressure.DoubleInteger(n);
        }
    }
}