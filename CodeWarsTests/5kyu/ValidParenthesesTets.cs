using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class ValidParenthesesTets
    {
        [Test]
        public void SampleTest1()
        {
            Assert.AreEqual(true, KataValidParentheses.ValidParentheses("()"));
        }

        [Test]
        public void SampleTest2()
        {
            Assert.AreEqual(false, KataValidParentheses.ValidParentheses(")(((("));
        }

        [Test]
        public void SampleTest3()
        {
            Assert.AreEqual(false, KataValidParentheses.ValidParentheses("hi)("));
        }

        [Test]
        public void SampleTest4()
        {
            Assert.AreEqual(true, KataValidParentheses.ValidParentheses("hi(hi)"));
        }
    }
}