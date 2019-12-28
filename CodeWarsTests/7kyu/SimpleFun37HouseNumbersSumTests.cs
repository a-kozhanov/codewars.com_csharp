using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    public class SimpleFun37HouseNumbersSumTests
    {
        [Test]
        public void BasicTests()
        {
            var kata = new SimpleFun37HouseNumbersSum();
            Assert.AreEqual(11, kata.HouseNumbersSum(new int[] {5, 1, 2, 3, 0, 1, 5, 0, 2}));
            Assert.AreEqual(13, kata.HouseNumbersSum(new int[] {4, 2, 1, 6, 0}));
            Assert.AreEqual(10, kata.HouseNumbersSum(new int[] {4, 1, 2, 3, 0, 10, 2}));
            Assert.AreEqual(0, kata.HouseNumbersSum(new int[] {0, 1, 2, 3, 4, 5}));
        }
    }
}