using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SumOfDigitsDigitalRootTests
    {
        private SumOfDigitsDigitalRoot num;

        [SetUp]
        public void SetUp()
        {
            num = new SumOfDigitsDigitalRoot();
        }

        [TearDown]
        public void TearDown()
        {
            num = null;
        }

        [Test]
        public void Tests()
        {
            Assert.AreEqual(7, num.DigitalRoot(16));
            Assert.AreEqual(6, num.DigitalRoot(456));
        }
    }
}