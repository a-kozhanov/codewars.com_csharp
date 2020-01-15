using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class BorrowerSpeakTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual("whatfickdamncake", BorrowerSpeak.Borrow("WhAt! FiCK! DaMn CAke?"));
            Assert.AreEqual("thebigpeoplehere", BorrowerSpeak.Borrow("THE big PeOpLE Here!!"));
            Assert.AreEqual("iamatinyboy", BorrowerSpeak.Borrow("i AM a TINY BoY!!"));
        }
    }
}