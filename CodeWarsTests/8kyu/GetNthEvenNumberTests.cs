using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class GetNthEvenNumberTests
    {
        [Test]
        [TestCase(1, ExpectedResult = 0)]
        [TestCase(3, ExpectedResult = 4)]
        [TestCase(100, ExpectedResult = 198)]
        [TestCase(1298734, ExpectedResult = 2597466)]
        public int FixedTest(int n)
        {
            return GetNthEvenNumber.NthEven(n);
        }
    }
}