using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class ParseFloatTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(1.0d, ParseFloat.ParseF("1"));
        }
    }
}