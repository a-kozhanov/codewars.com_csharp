using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class ConcatenatedSumTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(true, ConcatenatedSum.CheckConcatenatedSum(2997, 3));
            Assert.AreEqual(true, ConcatenatedSum.CheckConcatenatedSum(-2997, 3));
        }
    }
}