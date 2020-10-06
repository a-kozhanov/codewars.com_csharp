using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class GettingToKnowLINQTests
    {
        [Test]
        public void SumOfArrayTest()
        {
            Assert.AreEqual(6, GettingToKnowLINQ.Sum(new[] {2, 3, 1}));
        }

        [Test]
        public void CountOccurencesOfCharacterTest()
        {
            Assert.AreEqual(2, GettingToKnowLINQ.CountChar(new[] {'A', 'B', 'C', 'A'}, 'A'));
        }

        [Test]
        public void CalculateSquaresTest()
        {
            Assert.AreEqual(new[] {1, 4, 9, 16, 25, 36}, GettingToKnowLINQ.CalculateSquares(1, 6));
        }
    }
}