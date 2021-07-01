using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class HistogramDataTests
    {
        [Test]
        public void SimpleTest()
        {
            uint[] data = new uint[] {1, 1, 0, 1, 3, 2, 6};
            Assert.AreEqual(new uint[] {1, 3, 1, 1, 0, 0, 1}, HistogramData.Histogram(data, 1));
            Assert.AreEqual(new uint[] {4, 2, 0, 1}, HistogramData.Histogram(data, 2));
        }
    }
}