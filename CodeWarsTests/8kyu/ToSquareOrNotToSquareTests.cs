using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class ToSquareOrNotToSquareTests
    {
        [Test]
        public void BasicTests()
        {
            var input = new int[] { 4, 3, 9, 7, 2, 1 };
            var expected = new int[] { 2, 9, 3, 49, 4, 1 };
            Assert.AreEqual(string.Join(",", expected), string.Join(",", ToSquareOrNotToSquare.SquareOrSquareRoot(input)));

            input = new int[] { 100, 101, 5, 5, 1, 1 };
            expected = new int[] { 10, 10201, 25, 25, 1, 1 };
            Assert.AreEqual(string.Join(",", expected), string.Join(",", ToSquareOrNotToSquare.SquareOrSquareRoot(input)));

            input = new int[] { 1, 2, 3, 4, 5, 6 };
            expected = new int[] { 1, 4, 9, 2, 25, 36 };
            Assert.AreEqual(string.Join(",", expected), string.Join(",", ToSquareOrNotToSquare.SquareOrSquareRoot(input)));
        }
    }
}