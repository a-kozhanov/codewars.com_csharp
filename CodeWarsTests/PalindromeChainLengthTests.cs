using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class PalindromeChainLengthTests
    {
        [Test]
        public void Given87OutputShouldBe4()
        {
            Assert.AreEqual(4, PalindromeChainLength.palindromeChainLength(87));
            Assert.AreEqual(24, PalindromeChainLength.palindromeChainLength(89));
        }
    }
}