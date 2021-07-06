using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class Basics04RotateMatrixTests
    {
        [Test]
        public void smile67KataTest_withoutRandom1()
        {
            int[,] oldMatrix = new int[4, 4]
            {
                {-1, 4, 3, 4},
                {5, 6, 7, 8},
                {2, 5, 1, 7},
                {3, 14, -5, 3}
            };
            int[,] newMatrix = new int[4, 4]
            {
                {4, 8, 7, 3},
                {3, 7, 1, -5},
                {4, 6, 5, 14},
                {-1, 5, 2, 3}
            };
            Assert.AreEqual(newMatrix, new Basics04RotateMatrix().rotateMatrixLeft(oldMatrix));
        }

        [Test]
        public void smile67KataTest_withoutRandom2()
        {
            int[,] oldMatrix = new int[1, 1]
                {{-1}};
            int[,] newMatrix = new int[1, 1]
                {{-1}};
            Assert.AreEqual(newMatrix, new Basics04RotateMatrix().rotateMatrixLeft(oldMatrix));
        }

        [Test]
        public void smile67KataTest_withoutRandom3()
        {
            int[,] oldMatrix = new int[2, 4]
            {
                {-1, 4, 3, 4},
                {5, 6, 7, 8}
            };
            int[,] newMatrix = new int[4, 2]
            {
                {4, 8},
                {3, 7},
                {4, 6},
                {-1, 5}
            };
            Assert.AreEqual(newMatrix, new Basics04RotateMatrix().rotateMatrixLeft(oldMatrix));
        }

        [Test]
        public void smile67KataTest_withoutRandom4()
        {
            int[,] oldMatrix = new int[4, 2]
            {
                {-1, 4},
                {5, 6},
                {2, 5},
                {-5, 3}
            };
            int[,] newMatrix = new int[2, 4]
            {
                {4, 6, 5, 3},
                {-1, 5, 2, -5}
            };
            Assert.AreEqual(newMatrix, new Basics04RotateMatrix().rotateMatrixLeft(oldMatrix));
        }
    }
}