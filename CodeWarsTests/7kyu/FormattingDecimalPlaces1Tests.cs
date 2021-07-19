using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class FormattingDecimalPlaces1Tests
    {
        [Test]
        public void Test_01()
        {
            Assert.AreEqual(10.12, FormattingDecimalPlaces1.TwoDecimalPlaces(10.1289767789));
        }

        [Test]
        public void Test_Negative_02()
        {
            Assert.AreEqual(-7488.83, FormattingDecimalPlaces1.TwoDecimalPlaces(-7488.83485834983));
        }
    }
}