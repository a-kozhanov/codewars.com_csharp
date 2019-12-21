using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class ValidateCodeWithSimpleRegexTests
    {
        [Test]
        [TestCase("123", ExpectedResult = true)]
        [TestCase("248", ExpectedResult = true)]
        [TestCase("8", ExpectedResult = false)]
        [TestCase("321", ExpectedResult = true)]
        [TestCase("9453", ExpectedResult = false)]
        public static bool FixedTest(string code)
        {
            return ValidateCodeWithSimpleRegex.ValidateCode(code);
        }
    }
}