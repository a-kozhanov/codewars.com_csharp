using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class FormattingDecimalPlaces0Tests
    {
        [Test]
        public void Test_01()
        {
            Assert.AreEqual(4.66, FormattingDecimalPlaces0.TwoDecimalPlaces(4.659725356));
        }

        [Test]
        public void Test_02()
        {
            Assert.AreEqual(173735326.38, FormattingDecimalPlaces0.TwoDecimalPlaces(173735326.3783732637948948));
        }
    }
}