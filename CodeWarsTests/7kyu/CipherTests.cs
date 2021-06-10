using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class CipherTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.That(Cipher.Encode("Hello World!"), Is.EqualTo("ưɞʈʈʚÀȊʚʬʈɘÆ"));
            Assert.That(Cipher.Decode("ưɞʈʈʚÀȊʚʬʈɘÆ"), Is.EqualTo("Hello World!"));
        }
    }
}