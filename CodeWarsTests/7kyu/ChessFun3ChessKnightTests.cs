using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class ChessFun3ChessKnightTests
    {
        [Test]
        public void BasicTests()
        {
            var kata = new ChessFun3ChessKnight();

            Assert.AreEqual(2, kata.ChessKnight("a1"));

            Assert.AreEqual(6, kata.ChessKnight("c2"));

            Assert.AreEqual(8, kata.ChessKnight("d4"));

            Assert.AreEqual(6, kata.ChessKnight("g6"));
        }
    }
}