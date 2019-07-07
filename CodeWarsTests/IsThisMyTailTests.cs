using System.Collections.Generic;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class IsThisMyTailTests
    {
        private static IEnumerable<TestCaseData> testCases
        {
            get
            {
                yield return new TestCaseData("Fox", "x").Returns(true);
                yield return new TestCaseData("Rhino", "o").Returns(true);
                yield return new TestCaseData("Meerkat", "t").Returns(true);
                yield return new TestCaseData("Emu", "t").Returns(false);
                yield return new TestCaseData("Badger", "s").Returns(false);
                yield return new TestCaseData("Giraffe", "d").Returns(false);
            }
        }

        [Test, TestCaseSource("testCases")]
        public bool Test(string body, string tail) => IsThisMyTail.CorrectTail(body, tail);
    }
}