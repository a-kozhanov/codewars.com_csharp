using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class EANValidationTests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(true, EANValidation.Validate("9783815820865"));
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(false, EANValidation.Validate("9783815820864"));
        }

        [Test]
        public void Test3()
        {
            Assert.AreEqual(true, EANValidation.Validate("9783827317100"));
        }
    }
}