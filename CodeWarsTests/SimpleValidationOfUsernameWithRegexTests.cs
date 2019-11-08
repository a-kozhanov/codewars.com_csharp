using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SimpleValidationOfUsernameWithRegexTests
    {
        [Test]
        [TestCase("asddsa", ExpectedResult = true)]
        [TestCase("a", ExpectedResult = false)]
        [TestCase("Hass", ExpectedResult = false)]
        [TestCase("Hasd_12ssssssssssssssasasasasasssasassss", ExpectedResult = false)]
        [TestCase("", ExpectedResult = false)]
        [TestCase("____", ExpectedResult = true)]
        [TestCase("012", ExpectedResult = false)]
        [TestCase("p1pp1", ExpectedResult = true)]
        [TestCase("asd43 34", ExpectedResult = false)]
        [TestCase("asd43_34", ExpectedResult = true)]

        public static bool FixedTest(string username)
        {
            return SimpleValidationOfUsernameWithRegex.ValidateUsr(username);
        }
    }
}