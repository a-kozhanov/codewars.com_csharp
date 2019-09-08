using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class CalculatorTest
    {
        Calculator Evaluator { get; set; } = new Calculator();

        [Test]
        [TestCase("1-1", ExpectedResult = 0)]
        [TestCase("1+1", ExpectedResult = 2)]
        [TestCase("1 - 1", ExpectedResult = 0)]
        [TestCase("1* 1", ExpectedResult = 1)]
        [TestCase("1 /1", ExpectedResult = 1)]
        public double TestEvaluation(string expression)
        {
            return Evaluator.Evaluate(expression);
        }
    }
}