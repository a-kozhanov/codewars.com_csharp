using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class KataCreatePhoneNumberTests
    {
        [Test]
        [TestCase(new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 0}, ExpectedResult = "(123) 456-7890")]
        [TestCase(new int[] {1, 1, 1, 1, 1, 1, 1, 1, 1, 1}, ExpectedResult = "(111) 111-1111")]
        public static string FixedTest(int[] numbers)
        {
            return KataCreatePhoneNumber.CreatePhoneNumber(numbers);
        }
    }
}