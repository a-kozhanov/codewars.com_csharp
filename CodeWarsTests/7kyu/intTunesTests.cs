using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class intTunesTests
    {
        [Test]
        public void ExampleTests()
        {
            Assert.AreEqual(true, intTunes.IsTune(new int[] {1, 3, 6, 8, 10, 12}));
            Assert.AreEqual(true, intTunes.IsTune(new int[] {1, 3, 6, 8, 10, 12, 13, 15}));
            Assert.AreEqual(true, intTunes.IsTune(new int[] {1, 6, 3}));
            Assert.AreEqual(false, intTunes.IsTune(new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12}));
            Assert.AreEqual(true, intTunes.IsTune(new int[] {2, 4, 7, 9, 11, 13}));
        }
    }
}