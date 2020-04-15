using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SimpleFun49DecipherTests
    {
        [Test]
        public void BasicTests()
        {
            var kata = new SimpleFun49Decipher();

            Assert.AreEqual("easy", kata.Decipher("10197115121"));

            Assert.AreEqual("b", kata.Decipher("98"));

            Assert.AreEqual("z", kata.Decipher("122"));
        }
    }
}