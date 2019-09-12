using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class GetAsciiValueTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.That(GetAsciiValue.GetASCII('A'), Is.EqualTo(65));
            Assert.That(GetAsciiValue.GetASCII(' '), Is.EqualTo(32));
            Assert.That(GetAsciiValue.GetASCII('!'), Is.EqualTo(33));
        }
    }
}