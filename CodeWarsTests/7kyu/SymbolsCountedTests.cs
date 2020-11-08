using System.Collections.Generic;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SymbolsCountedTests
    {
        private static IEnumerable<TestCaseData> testCases
        {
            get
            {
                yield return new TestCaseData("elevation").Returns("e2lvation");
                yield return new TestCaseData("transplantology").Returns("t2ra2n2spl2o2gy");
                yield return new TestCaseData("economics").Returns("ec2o2nmis");
                yield return new TestCaseData("embarrassed").Returns("e2mba2r2s2d");
                yield return new TestCaseData("impressive").Returns("i2mpre2s2v");
            }
        }

        [Test, TestCaseSource("testCases")]
        public string Test(string s) => SymbolsCounted.Transform(s);
    }
}