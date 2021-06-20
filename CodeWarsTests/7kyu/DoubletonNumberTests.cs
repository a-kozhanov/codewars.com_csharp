using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class DoubletonNumberTests
    {
        private static void Act(int num, int expected)
        {
            var actual = DoubletonNumber.Doubleton(num);
            Assert.AreEqual(expected, actual, $"Input: num = {num}");
        }

        [Test(Description = "Fixed Tests")]
        public void FixedTests()
        {
            Act(120, 121);
            Act(1234, 1311);
            Act(1, 10);
            Act(10, 12);
        }
    }
}