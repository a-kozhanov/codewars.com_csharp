using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class GetCharacterFromASCIIValueTests
    {
        [Test]
        [TestCase(55, ExpectedResult = '7')]
        [TestCase(55, ExpectedResult = '7')]
        [TestCase(56, ExpectedResult = '8')]
        [TestCase(57, ExpectedResult = '9')]
        [TestCase(58, ExpectedResult = ':')]
        [TestCase(59, ExpectedResult = ';')]
        [TestCase(60, ExpectedResult = '<')]
        [TestCase(61, ExpectedResult = '=')]
        [TestCase(62, ExpectedResult = '>')]
        [TestCase(63, ExpectedResult = '?')]
        [TestCase(64, ExpectedResult = '@')]
        [TestCase(65, ExpectedResult = 'A')]
        public static char FixedTest(int charCode)
        {
            return GetCharacterFromASCIIValue.GetChar(charCode);
        }
    }
}