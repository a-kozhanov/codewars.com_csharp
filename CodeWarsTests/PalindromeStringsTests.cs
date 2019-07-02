using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using CodeWars;

namespace CodeWarsTests
{
    [TestFixture]
    class PalindromeStringsTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(true, PalindromeStrings.IsPalindrome("anna"));
            Assert.AreEqual(false, PalindromeStrings.IsPalindrome("walter"));
            Assert.AreEqual(true, PalindromeStrings.IsPalindrome(12321));
            Assert.AreEqual(false, PalindromeStrings.IsPalindrome(123456));
        }
    }
}
