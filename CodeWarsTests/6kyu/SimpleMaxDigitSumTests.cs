using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SimpleMaxDigitSumTests
    {
        [Test]
        public void ExampleTests()
        {
            Assert.AreEqual(1, SimpleMaxDigitSum.solve(1));
            Assert.AreEqual(2, SimpleMaxDigitSum.solve(2));
            Assert.AreEqual(18, SimpleMaxDigitSum.solve(18));
            Assert.AreEqual(48, SimpleMaxDigitSum.solve(48));
            Assert.AreEqual(99, SimpleMaxDigitSum.solve(100));
            Assert.AreEqual(9, SimpleMaxDigitSum.solve(10));
            Assert.AreEqual(99, SimpleMaxDigitSum.solve(110));
            Assert.AreEqual(1999, SimpleMaxDigitSum.solve(2090));
            Assert.AreEqual(999999999989, SimpleMaxDigitSum.solve(999999999992));
        }
    }
}