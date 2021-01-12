using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class OldSwitcheroo2Tests
    {
        [Test]
        [TestCase("abc", ExpectedResult = "123")]
        [TestCase("ABCD", ExpectedResult = "1234")]
        [TestCase("ZzzzZ", ExpectedResult = "2626262626")]
        [TestCase("abc-#@5", ExpectedResult = "123-#@5")]
        [TestCase("this is a long string!! Please [encode] @C0RrEctly",
            ExpectedResult = "208919 919 1 1215147 1920189147!! 161251195 [51431545] @30181853201225")]
        public static string FixedTest(string str)
        {
            return OldSwitcheroo2.Encode(str);
        }
    }
}