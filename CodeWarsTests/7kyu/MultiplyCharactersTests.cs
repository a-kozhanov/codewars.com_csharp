using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class MultiplyCharactersTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual("hue", MultiplyCharacters.Spam(1));
            Assert.AreEqual("huehuehuehuehuehue", MultiplyCharacters.Spam(6));
            Assert.AreEqual("huehuehuehuehuehuehuehuehuehuehuehuehuehue", MultiplyCharacters.Spam(14));
        }
    }
}