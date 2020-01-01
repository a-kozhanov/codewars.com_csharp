using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class KataRemoveDuplicateWordsTests
    {
        [Test, Description("Should handle sample case")]
        public void ExampleTest()
        {
            Assert.That(
                KataRemoveDuplicateWords.RemoveDuplicateWords(
                    "alpha beta beta gamma gamma gamma delta alpha beta beta gamma gamma gamma delta"),
                Is.EqualTo("alpha beta gamma delta"));
        }
    }
}