using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class FixStringCaseTests
    {
        [TestCase("code", "code")]
        [TestCase("CODe", "CODE")]
        [TestCase("COde", "code")]
        [TestCase("Code", "code")]
        public void BasicTests(string s, string expected)
        {
            Assert.That(FixStringCase.Solve(s), Is.EqualTo(expected));
        }
    }
}