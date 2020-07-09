using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class FilterNumberTests
    {
        [Test]
        public static void FixedTests()
        {
            Assert.AreEqual(123, FilterNumber.FilterString("123"), "Just return the numbers");
            Assert.AreEqual(123, FilterNumber.FilterString("a1b2c3"), "Just return the numbers");
            Assert.AreEqual(123, FilterNumber.FilterString("aa1bb2cc3dd"), "Just return the numbers");
        }
    }
}