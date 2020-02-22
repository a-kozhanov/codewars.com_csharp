using System.Collections.Generic;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class WordValuesTests
    {
        private static IEnumerable<TestCaseData> sampleTestCases
        {
            get
            {
                yield return new TestCaseData(new[] {new string[] {"codewars", "abc", "xyz"}}).Returns(new int[]
                    {88, 12, 225});
                yield return new TestCaseData(new[] {new string[] {"abc abc", "abc abc", "abc", "abc"}}).Returns(
                    new int[] {12, 24, 18, 24});
            }
        }

        [Test, TestCaseSource("sampleTestCases")]
        public int[] SampleTest(string[] a) => WordValues.WordValue(a);
    }
}