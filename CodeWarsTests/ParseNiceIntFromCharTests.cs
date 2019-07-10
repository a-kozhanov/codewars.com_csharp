using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class ParseNiceIntFromCharTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(3, ParseNiceIntFromChar.GetAge("3 years old"));
            Assert.AreEqual(4, ParseNiceIntFromChar.GetAge("4 years old"));
            Assert.AreEqual(9, ParseNiceIntFromChar.GetAge("9 years old"));
        }
    }
}