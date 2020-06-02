using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class FindSumOfTopLeftToBottomRightDiagonalsTests
    {
        [Test]
        public void SampleTest()
        {
            //Assert.AreEqual(12, FindSumOfTopLeftToBottomRightDiagonals.DiagonalSum(new int[,] {{12}}));
            
            Assert.AreEqual(5, FindSumOfTopLeftToBottomRightDiagonals.DiagonalSum(new int[2, 2] {{1, 2}, {3, 4}}));
            
            Assert.AreEqual(15,
                FindSumOfTopLeftToBottomRightDiagonals.DiagonalSum(new int[,] {{1, 2, 3}, {4, 5, 6}, {7, 8, 9}}));
            
            Assert.AreEqual(34,
                FindSumOfTopLeftToBottomRightDiagonals.DiagonalSum(new int[,]
                    {{1, 2, 3, 4}, {5, 6, 7, 8}, {9, 10, 11, 12}, {13, 14, 15, 16}}));
        }
    }
}