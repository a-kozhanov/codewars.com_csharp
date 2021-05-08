using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class CreatePalindromeTests
    {
        [Test]
        public void ExampleTests()
        {
            Assert.AreEqual(true, CreatePalindrome.solve("abba"));
            Assert.AreEqual(false, CreatePalindrome.solve("abaazaba"));
            Assert.AreEqual(true, CreatePalindrome.solve("abccba"));
            Assert.AreEqual(true, CreatePalindrome.solve("adfa"));
            Assert.AreEqual(false, CreatePalindrome.solve("ae"));
            Assert.AreEqual(true, CreatePalindrome.solve("sq"));
            Assert.AreEqual(false, CreatePalindrome.solve("abzy"));
            Assert.AreEqual(true,
                CreatePalindrome.solve(
                    "kxbkwgyydkcbtjcosgikfdyhuuprubpwthgflucpyylbofvqxkkvqthmdnywpaunfihvupbwpruwfybdmgeuocltdaidyyewmbzm"));
        }
    }
}