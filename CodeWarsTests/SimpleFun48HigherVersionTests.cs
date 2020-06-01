using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SimpleFun48HigherVersionTests
    {
        [Test]
        public void BasicTests()
        {
            var kata = new SimpleFun48HigherVersion();

            Assert.AreEqual(true, kata.HigherVersion("1.2.2", "1.2.0"));

            Assert.AreEqual(false, kata.HigherVersion("1.0.5", "1.1.0"));

            Assert.AreEqual(false, kata.HigherVersion("1.1.0", "1.1.5"));

            Assert.AreEqual(true, kata.HigherVersion("10", "9"));

            Assert.AreEqual(false, kata.HigherVersion("1.0.10", "1.1.5"));

            Assert.AreEqual(false, kata.HigherVersion("1.1.10", "1.2.0"));

            Assert.AreEqual(false, kata.HigherVersion("1.2.2", "1.2.10"));

            Assert.AreEqual(true, kata.HigherVersion("1.10.2", "1.2.10"));

            Assert.AreEqual(false, kata.HigherVersion("4.3.22.1", "4.3.22.1"));
        }
    }
}