using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class AllStarCodeChallenge18Tests
    {
        [TestCase("Hello", "o", 1)]
        [TestCase("Hello", "l", 2)]
        [TestCase("", "z", 0)]
        public void BasicTetst(string a, string b, int expected)
        {
            Assert.That(AllStarCodeChallenge18.StrCount(a, b), Is.EqualTo(expected));
        }
    }
}