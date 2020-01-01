using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class KataReverseWordsTests
    {
        [Test]
        public void Example()
        {
            Assert.AreEqual("sihT si na !elpmaxe", KataReverseWords.ReverseWords("This is an example!"));
        }
    }
}