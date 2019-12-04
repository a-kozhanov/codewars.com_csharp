using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class FIXMEReplaceAllDotsTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual("one-two-three", FIXMEReplaceAllDots.ReplaceDots("one.two.three"));
        }
    }
}