using System.Collections.Generic;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class KindRemaInderTests
    {
        [TestFixture]
        public class SampleTest
        {
            private static IEnumerable<TestCaseData> testCases
            {
                get
                {
                    yield return new TestCaseData(new List<int> {16, 16}, new List<int> {10, 5}, "Doctor")
                        .Returns("doctor")
                        .SetDescription(
                            "Kata.Kira(new List<int>{16, 16}, new List<int>{10, 5}, \"Doctor\") =>\n\t \"doctor\"");
                }
            }

            [Test, TestCaseSource("testCases")]
            public string Test(List<int> a, List<int> b, string c) => KindRemaInder.Kira(a, b, c);
        }
    }
}