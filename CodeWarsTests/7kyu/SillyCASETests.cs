using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SillyCASETests
    {
        [Test]
        public void SampleTest()
        {
            Assert.That(SillyCASE.SillyCase("foobar"), Is.EqualTo("fooBAR"));
            Assert.That(SillyCASE.SillyCase("codewars"), Is.EqualTo("codeWARS"));
            Assert.That(SillyCASE.SillyCase("brian"), Is.EqualTo("briAN"));
        }
    }
}