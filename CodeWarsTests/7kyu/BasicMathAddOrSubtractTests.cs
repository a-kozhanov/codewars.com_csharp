using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class BasicMathAddOrSubtractTests
    {
        [Test(Description = "Basic (fixed) tests")]
        public void BasicTests()
        {
            Test("10", "1plus2plus3plus4");
            Test("-8", "1minus2minus3minus4");
            Test("2", "1plus2plus3minus4");
            Test("-2", "1minus2plus3minus4");
            Test("-1", "1plus2minus3plus4minus5");
        }

        private void Test(string solution, string input)
        {
            Assert.AreEqual(solution, BasicMathAddOrSubtract.Calculate(input),
                $"Incorrect answer for input \"{input}\"");
        }
    }
}