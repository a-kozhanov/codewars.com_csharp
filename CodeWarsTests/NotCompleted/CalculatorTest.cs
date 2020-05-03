using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class CalculatorTest
    {
        Calculator Evaluator { get; set; } = new Calculator();

        [Test]
        [TestCase("12*-1", ExpectedResult = -12)]
        [TestCase("12* 123/-(-5 + 2)", ExpectedResult = 492)]
        [TestCase("((80 - (19)))", ExpectedResult = 61)]
        [TestCase("(1 - 2) + -(-(-(-4)))", ExpectedResult = 3)]
        [TestCase("1 - -(-(-(-4)))", ExpectedResult = -3)]
        [TestCase("12* 123/(-5 + 2)", ExpectedResult = -492)]
        [TestCase(
            "(123.45*(678.90 / (-2.5+ 11.5)-(((80 -(19))) *33.25)) / 20) - (123.45*(678.90 / (-2.5+ 11.5)-(((80 -(19))) *33.25)) / 20) + (13 - 2)/ -(-11) ",
            ExpectedResult = 1)]
        [TestCase("1+1", ExpectedResult = 2)]
        [TestCase("1 - 1", ExpectedResult = 0)]
        [TestCase("1* 1", ExpectedResult = 1)]
        [TestCase("1 /1", ExpectedResult = 1)]
        [TestCase("-123", ExpectedResult = -123)]
        [TestCase("123", ExpectedResult = 123)]
        [TestCase("2 /2+3 * 4.75- -6", ExpectedResult = 21.25)]
        [TestCase("12* 123", ExpectedResult = 1476)]
        [TestCase("12 * -123", ExpectedResult = -1476)]
        [TestCase("2 / (2 + 3) * 4.33 - -6", ExpectedResult = 7.732)]
        [TestCase("((2.33 / (2.9+3.5)*4) - -6)", ExpectedResult = 7.45625)]
        [TestCase("123.45*(678.90 / (-2.5+ 11.5)-(80 -19) *33.25) / 20 + 11", ExpectedResult = -12042.760875)]
        public double TestEvaluation(string expression)
        {
            return Evaluator.Evaluate(expression);
        }
    }
}