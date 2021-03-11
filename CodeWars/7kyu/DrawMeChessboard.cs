/*
https://www.codewars.com/kata/56242b89689c35449b000059/csharp

7 kyu
draw me a chessboard

A grid is a perfect starting point for many games (Chess, battleships, Candy Crush!).

Making a digital chessboard I think is an interesting way of visualising how loops can work together.

Your task is to write a function that takes two integers rows and columns and returns a chessboard pattern as a two dimensional array.

So chessBoard(6,4) should return an array like this:

[
    ["O","X","O","X"],
    ["X","O","X","O"],
    ["O","X","O","X"],
    ["X","O","X","O"],
    ["O","X","O","X"],
    ["X","O","X","O"]
]
And chessBoard(3,7) should return this:

[
    ["O","X","O","X","O","X","O"],
    ["X","O","X","O","X","O","X"],
    ["O","X","O","X","O","X","O"]
]
The white spaces should be represented by an: 'O'

and the black an: 'X'

The first row should always start with a white space 'O'
*/

using System.Linq;

namespace CodeWars
{
    public class DrawMeChessboard
    {
        public static char[][] ChessBoard(int row, int columns)
        {
            return new int[row].Select((_, i) => new int[columns].Select((_, j) => (i + j) % 2 == 0 ? 'O' : 'X').ToArray()).ToArray();
            //return new int[row].Select((_, i) => new int[columns].Select((_, j) => new[] {'O', 'X'}[(i + j) % 2]).ToArray()).ToArray();


            // return Enumerable.Range(0, row)
            //     .Select(i => Enumerable.Range(0, columns).Select(j => (i & 1) == (j & 1) ? 'O' : 'X').ToArray())
            //     .ToArray();

            // return Enumerable.Range(0, row)
            //     .Select(x => Enumerable.Range(0, columns).Select(y => (y + x) % 2 == 0 ? 'O' : 'X').ToArray())s
            //     .ToArray();


            // return Enumerable.Range(0, row)
            //     .Select(r => Enumerable.Range(0, columns).Select(c => (r + c) % 2 == 0 ? 'O' : 'X').ToArray())
            //     .ToArray();
        }
    }
}