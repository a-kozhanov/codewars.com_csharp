using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class GCDSumTests
    {
        [Test]
        public void ExampleTests()
        {
            Assert.AreEqual((3, 3), GCDSum.solve(6, 3));
            Assert.AreEqual((2, 6), GCDSum.solve(8, 2));
            Assert.AreEqual((-1, -1), GCDSum.solve(10, 3));
            Assert.AreEqual((4, 8), GCDSum.solve(12, 4));
            Assert.AreEqual((-1, -1), GCDSum.solve(12, 5));
            Assert.AreEqual((10, 40), GCDSum.solve(50, 10));
            Assert.AreEqual((-1, -1), GCDSum.solve(50, 4));
            Assert.AreEqual((5, 5), GCDSum.solve(10, 5));
            Assert.AreEqual((5, 95), GCDSum.solve(100, 5));
            Assert.AreEqual((5, 995), GCDSum.solve(1000, 5));
        }
    }
}