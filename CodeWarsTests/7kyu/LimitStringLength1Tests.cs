using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class LimitStringLength1Tests
    {
        [TestFixture]
        public class SolutionTest
        {
            private static object[] sampleTestCases = new object[]
            {
                new object[] {"Testing String", 3, "Tes..."},
                new object[] {"Testing String", 8, "Testing ..."},
                new object[] {"Test", 4, "Test"},
                new object[] {"Test", 10, "Test"},
            };

            [Test, TestCaseSource("sampleTestCases")]
            public void SampleTest(string text, int limit, string expected)
            {
                Assert.AreEqual(expected, LimitStringLength1.Limit(text, limit));
            }
        }
    }
}