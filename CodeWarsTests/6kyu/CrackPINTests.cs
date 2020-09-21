using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class CrackPINTests
    {
        [Test]
        public void SimpleTest()
        {
            Assert.AreEqual("12345", CrackPIN.crack("827ccb0eea8a706c4c34a16891f84e7b"));
        }

        [Test]
        public void HarderTest()
        {
            Assert.AreEqual("00078", CrackPIN.crack("86aa400b65433b608a9db30070ec60cd"));
        }
    }
}