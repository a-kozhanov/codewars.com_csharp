using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class NiceArrayTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(true, NiceArray.IsNice(new int[] {2, 10, 9, 3}));
            Assert.AreEqual(false, NiceArray.IsNice(new int[] {3, 4, 5, 7}));
            Assert.AreEqual(true, NiceArray.IsNice(new int[] {3, 2, 1, 0}));
        }
    }
}