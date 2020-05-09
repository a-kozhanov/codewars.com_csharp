using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class KataSwitcherooTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual("bac", KataSwitcheroo.Switcheroo("abc"));
            Assert.AreEqual("bbbacccabbb", KataSwitcheroo.Switcheroo("aaabcccbaaa"));
            Assert.AreEqual("ccccc", KataSwitcheroo.Switcheroo("ccccc"));
        }
    }
}