using System.Collections.Generic;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class CollatzConjectureTests
    {
        private static IEnumerable<TestCaseData> testCases
        {
            get
            {
                yield return new TestCaseData(1u).Returns(0u);
                yield return new TestCaseData(5u).Returns(5u);
                yield return new TestCaseData(6u).Returns(8u);
                yield return new TestCaseData(23u).Returns(15u);
            }
        }

        [Test, TestCaseSource("testCases")]
        public uint SampleTest(uint n) => CollatzConjecture.Hotpo(n);
    }
}