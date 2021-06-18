using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class TwoDimensionalArrayOperationTests
    {
        [Test]
        public void MyTest()
        {
            Assert.AreEqual(4, TwoDimensionalArrayOperation.Result(new int[,] {{4}}));
            Assert.AreEqual(21, TwoDimensionalArrayOperation.Result(new int[,] {{1, 2}, {3, 4}}));
            Assert.AreEqual(5376,
                TwoDimensionalArrayOperation.Result(new int[,] {{7, 1, 5, 8}, {2, 1, 4, 9}, {3, 2, 4, 7}}));
        }
    }
}