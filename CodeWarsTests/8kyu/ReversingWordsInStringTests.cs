using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class ReversingWordsInStringTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual("World Hello", ReversingWordsInString.Reverse("Hello World"));
            Assert.AreEqual("There. Hi", ReversingWordsInString.Reverse("Hi There."));

            Assert.AreEqual("this at expert an am I", ReversingWordsInString.Reverse("I am an expert at this"));
        }
    }
}