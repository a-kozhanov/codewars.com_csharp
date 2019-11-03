using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class IsItEvenTests
    {
        private IsItEven num;

        [SetUp]
        public void SetUp()
        {
            num = new IsItEven();
        }

        [TearDown]
        public void TearDown()
        {
            num = null;
        }

        [Test]
        public void Tests()
        {
            Assert.AreEqual(true, num.IsEven(0));
            Assert.AreEqual(false, num.IsEven(0.5));
            Assert.AreEqual(false, num.IsEven(1));
            Assert.AreEqual(true, num.IsEven(2));
            Assert.AreEqual(true, num.IsEven(-4));
        }
    }
}