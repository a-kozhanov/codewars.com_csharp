using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class IsStringUppercaseTests
    {
        [Test]
        [TestCase("c", ExpectedResult = false)]
        [TestCase("C", ExpectedResult = true)]
        [TestCase("hello I AM DONALD", ExpectedResult = false)]
        [TestCase("HELLO I AM DONALD", ExpectedResult = true)]
        [TestCase("ACSKLDFJSgSKLDFJSKLDFJ", ExpectedResult = false)]
        [TestCase("ACSKLDFJSGSKLDFJSKLDFJ", ExpectedResult = true)]

        public static bool FixedTest(string str)
        {
            return str.IsUpperCase();
        }
    }
}