using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class DidSheSayHalloTests
    {
        [Test]
        public void Test1()
        {
            Assert.IsTrue(DidSheSayHallo.Validate_hello("hello"));
            Assert.IsTrue(DidSheSayHallo.Validate_hello("ciao bella!"));
            Assert.IsTrue(DidSheSayHallo.Validate_hello("salut"));
            Assert.IsTrue(DidSheSayHallo.Validate_hello("hallo, salut"));
            Assert.IsTrue(DidSheSayHallo.Validate_hello("hombre! Hola!"));
            Assert.IsTrue(DidSheSayHallo.Validate_hello("Hallo, wie geht\'s dir?"));
            Assert.IsTrue(DidSheSayHallo.Validate_hello("AHOJ!"));
            Assert.IsTrue(DidSheSayHallo.Validate_hello("czesc"));
            Assert.IsTrue(DidSheSayHallo.Validate_hello("Ahoj"));
            Assert.IsFalse(DidSheSayHallo.Validate_hello("meh"));
        }
    }
}