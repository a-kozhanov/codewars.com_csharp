using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SimpleBeadsCountTests
    {
        [Test, Description("Basic Tests")]
        public void SampleTest()
        {
            Assert.That(SimpleBeadsCount.CountRedBeads(0), Is.EqualTo(0));
            Assert.That(SimpleBeadsCount.CountRedBeads(1), Is.EqualTo(0));
            Assert.That(SimpleBeadsCount.CountRedBeads(3), Is.EqualTo(4));
            Assert.That(SimpleBeadsCount.CountRedBeads(5), Is.EqualTo(8));
        }
    }
}