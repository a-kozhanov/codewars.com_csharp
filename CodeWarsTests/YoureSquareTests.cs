using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class YoureSquareTests
    {
        [Test]
        public static void ShouldWorkForSomeExamples()
        {
            Assert.AreEqual(false, YoureSquare.IsSquare(-1), "negative numbers aren't square numbers");
            Assert.AreEqual(false, YoureSquare.IsSquare(3), "3 isn't a square number");
            Assert.AreEqual(true, YoureSquare.IsSquare(4), "4 is a square number");
            Assert.AreEqual(true, YoureSquare.IsSquare(25), "25 is a square number");
            Assert.AreEqual(false, YoureSquare.IsSquare(26), "26 isn't a square number");
        }
    }
}