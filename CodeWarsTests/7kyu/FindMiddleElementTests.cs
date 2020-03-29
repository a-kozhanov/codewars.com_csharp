using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class FindMiddleElementTests
    {
        [Test]
        public void SampleTests()
        {
            Assert.AreEqual(0, FindMiddleElement.Gimme(new double[] {2, 3, 1}));
            Assert.AreEqual(1, FindMiddleElement.Gimme(new double[] {5, 10, 14}));
        }
    }
}