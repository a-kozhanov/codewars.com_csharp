using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class ValidBracesTests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(true, ValidBraces.validBraces("()"));
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(false, ValidBraces.validBraces("[(])"));
        }
    }
}