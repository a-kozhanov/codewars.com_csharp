using System.Collections.Generic;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    public class ChangingLettersTests
    {
        private static IEnumerable<TestCaseData> testCases
        {
            get
            {
                yield return new TestCaseData("HelloWorld!").Returns("HEllOWOrld!");
                yield return new TestCaseData("Sunday").Returns("SUndAy");
            }
        }

        [Test, TestCaseSource("testCases")]
        public string Test(string s) => ChangingLetters.Swap(s);
    }
}