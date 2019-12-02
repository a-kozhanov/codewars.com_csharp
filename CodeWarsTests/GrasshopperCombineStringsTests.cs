using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class GrasshopperCombineStringsTests
    {
        [Test]
        [TestCase("James", "Stevens", ExpectedResult = "James Stevens")]
        public static string FixedTest(string a, string b)
        {
            return GrasshopperCombineStrings.CombineNames(a, b);
        }
    }
}