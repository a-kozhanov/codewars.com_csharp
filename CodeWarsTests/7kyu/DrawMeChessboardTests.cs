using System;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class DrawMeChessboardTests
    {
        private Random rand = new Random();

        [Test]
        public void FormatTests()
        {
            for (var i = 0; i < 4; i++)
            {
                var rows = rand.Next(1, 21);
                var columns = rand.Next(1, 21);

                Assert.AreEqual(rows, DrawMeChessboard.ChessBoard(rows, columns).Length,
                    "make sure the board has the correct number of rows");
                Assert.AreEqual(columns, DrawMeChessboard.ChessBoard(rows, columns)[0].Length,
                    "make sure the board has the correct number of columns");
            }
        }

        [Test]
        public void AlternatingContentTests()
        {
            for (var i = 0; i < 3; i++)
            {
                var rows = rand.Next(2, 12);
                var columns = rand.Next(2, 12);

                Console.WriteLine(rows + " - rows, " + columns + " - columns");

                var board = DrawMeChessboard.ChessBoard(rows, columns);

                Assert.AreEqual(rows, board.Length, "make sure the board has the correct number of rows");

                for (var j = 0; j < rows; j += 2)
                {
                    Assert.AreEqual('O', board[j][0]);
                    if (j + 1 < rows)
                    {
                        Assert.AreEqual('X', board[j + 1][0]);
                    }
                }
            }
        }
    }
}