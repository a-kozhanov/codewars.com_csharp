using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class WelcomeTests
    {
        [Test]
        public void BasicTest()
        {
            Assert.AreEqual("Welcome", Welcome.Greet("english"));
            Assert.AreEqual("Welkom", Welcome.Greet("dutch"));
            Assert.AreEqual("Welcome", Welcome.Greet("IP_ADDRESS_INVALID"));
            Assert.AreEqual("Welcome", Welcome.Greet(""));
            Assert.AreEqual("Welcome", Welcome.Greet("2"));
        }
    }
}