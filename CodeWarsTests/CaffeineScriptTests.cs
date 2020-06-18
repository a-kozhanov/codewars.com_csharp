using System.Collections.Generic;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class CaffeineScriptTests
    {
        private static IEnumerable<TestCaseData> testCases
        {
            get
            {
                yield return new TestCaseData(1).Returns("mocha_missing!");
                yield return new TestCaseData(3).Returns("Java");
                yield return new TestCaseData(6).Returns("JavaScript");
                yield return new TestCaseData(12).Returns("CoffeeScript");
            }
        }

        [Test, TestCaseSource("testCases")]
        public string Test(int n) => CaffeineScript.CaffeineBuzz(n);
    }
}