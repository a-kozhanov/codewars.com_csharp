using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class EqualSidesOfAnArrayTests
    {
        [Test]
        public void GenericTests()
        {
            Assert.AreEqual(3, EqualSidesOfAnArray.FindEvenIndex(new int[] {1, 2, 3, 4, 3, 2, 1}));
            Assert.AreEqual(1, EqualSidesOfAnArray.FindEvenIndex(new int[] {1, 100, 50, -51, 1, 1}));
            Assert.AreEqual(-1, EqualSidesOfAnArray.FindEvenIndex(new int[] {1, 2, 3, 4, 5, 6}));
            Assert.AreEqual(3, EqualSidesOfAnArray.FindEvenIndex(new int[] {20, 10, 30, 10, 10, 15, 35}));
        }
    }
}