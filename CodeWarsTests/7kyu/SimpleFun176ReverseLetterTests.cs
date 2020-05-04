using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SimpleFun176ReverseLetterTests
    {
        [Test]
        public void BasicTests()
        {
            var kata = new SimpleFun176ReverseLetter();

            Assert.AreEqual("nahsirk", kata.ReverseLetter("krishan"));

            Assert.AreEqual("nortlu", kata.ReverseLetter("ultr53o?n"));

            Assert.AreEqual("cba", kata.ReverseLetter("ab23c"));

            Assert.AreEqual("nahsirk", kata.ReverseLetter("krish21an"));
        }
    }
}