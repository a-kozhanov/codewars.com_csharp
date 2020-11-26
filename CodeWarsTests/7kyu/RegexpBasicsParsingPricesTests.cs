using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class RegexpBasicsParsingPricesTests
    {
        [Test]
        public void _0_BasicTests()
        {
            Assert.AreEqual(null, "".ToCents());
            Assert.AreEqual(null, "1".ToCents());
            Assert.AreEqual(null, "1.23".ToCents());
            Assert.AreEqual(null, "$1".ToCents());
            Assert.AreEqual(123, "$1.23".ToCents());
            Assert.AreEqual(9999, "$99.99".ToCents());
            Assert.AreEqual(1234567890, "$12345678.90".ToCents());
            Assert.AreEqual(969, "$9.69".ToCents());
            Assert.AreEqual(970, "$9.70".ToCents());
            Assert.AreEqual(971, "$9.71".ToCents());
            Assert.AreEqual(69, "$0.69".ToCents());
            Assert.AreEqual(null, "$9.69$4.3.7".ToCents());
            Assert.AreEqual(null, "$9.692".ToCents());
        }
    }
}