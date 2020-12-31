using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class UnscrambledEggsTests
    {
        [Test]
        public void BasicTest()
        {
            Assert.AreEqual("code here", UnscrambledEggs.UnscrambleEggs("ceggodegge heggeregge"));
            Assert.AreEqual("FUN KATA", UnscrambledEggs.UnscrambleEggs("FeggUNegg KeggATeggA"));
        }
    }
}