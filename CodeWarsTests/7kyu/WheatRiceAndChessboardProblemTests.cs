using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class WheatRiceAndChessboardProblemTests
    {
        [Test]
        public void FixedTest()
        {
            Assert.AreEqual(0, WheatRiceAndChessboardProblem.SquaresNeeded(0));
            Assert.AreEqual(1, WheatRiceAndChessboardProblem.SquaresNeeded(1));
            Assert.AreEqual(2, WheatRiceAndChessboardProblem.SquaresNeeded(2));
            Assert.AreEqual(2, WheatRiceAndChessboardProblem.SquaresNeeded(3));
            Assert.AreEqual(3, WheatRiceAndChessboardProblem.SquaresNeeded(4));
        }
    }
}