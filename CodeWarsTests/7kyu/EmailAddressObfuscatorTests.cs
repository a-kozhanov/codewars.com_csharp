using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class EmailAddressObfuscatorTests
    {
        [Test]
        public void test1()
        {
            Assert.AreEqual("test [at] 123 [dot] com",
                EmailAddressObfuscator.Obfuscate("test@123.com"));
        }

        [Test]
        public void test2()
        {
            Assert.AreEqual("Code_warrior [at] foo [dot] ac [dot] uk",
                EmailAddressObfuscator.Obfuscate("Code_warrior@foo.ac.uk"));
        }
    }
}