using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class TripleShiftianNumbersTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(1219856746L, TripleShiftianNumbers.TripleShiftian(new int[] {1, 1, 1}, 25));
            Assert.AreEqual(2052198929L, TripleShiftianNumbers.TripleShiftian(new int[] {1, 2, 3}, 25));
            Assert.AreEqual(2827228055L, TripleShiftianNumbers.TripleShiftian(new int[] {3, 2, 1}, 25));
            Assert.AreEqual(-2575238999L, TripleShiftianNumbers.TripleShiftian(new int[] {6, 7, 2}, 25));
            Assert.AreEqual(10127083068293L, TripleShiftianNumbers.TripleShiftian(new int[] {1, 1, 1}, 35));
            Assert.AreEqual(17037073417493L, TripleShiftianNumbers.TripleShiftian(new int[] {1, 2, 3}, 35));
            Assert.AreEqual(23471258855679L, TripleShiftianNumbers.TripleShiftian(new int[] {3, 2, 1}, 35));
            Assert.AreEqual(-21379280887590L, TripleShiftianNumbers.TripleShiftian(new int[] {6, 7, 2}, 35));
            Assert.AreEqual(3L, TripleShiftianNumbers.TripleShiftian(new int[] {3, 2, 1}, 3));
            Assert.AreEqual(2L, TripleShiftianNumbers.TripleShiftian(new int[] {6, 7, 2}, 2));
        }
    }
}