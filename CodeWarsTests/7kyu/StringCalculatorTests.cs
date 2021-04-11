using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class StringCalculatorTests
    {
        [Test]
        public void LessThan10()
        {
            Assert.AreEqual(5, StringCalculator.AddStrings("2, 3"));
        }

        [Test]
        public void Over50()
        {
            Assert.AreEqual(60, StringCalculator.AddStrings("20, 20, 20"));
        }
    }
}