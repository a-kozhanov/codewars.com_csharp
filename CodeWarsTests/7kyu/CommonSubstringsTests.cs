using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class CommonSubstringsTests
    {
        [Test]
        public void ShouldBeTrue()
        {
            Assert.AreEqual(true, CommonSubstrings.SubstringTest("Something", "Home"));
        }

        [Test]
        public void ShouldBeFalse()
        {
            Assert.AreEqual(false, CommonSubstrings.SubstringTest("Something", "Fun"));
        }
    }
}