/*
https://www.codewars.com/kata/589433358420bf25950000b6/csharp

7 kyu
Chess Fun #3: Chess Knight

Task
Given a position of a knight on the standard chessboard, find the number of different moves the knight can perform.

The knight can move to a square that is two squares horizontally and one square vertically, 
or two squares vertically and one square horizontally away from it. 
The complete move therefore looks like the letter L. 
Check out the image below to see all valid moves for a knight piece that is placed on one of the central squares.

Example
For cell = "a1", the output should be 2.

For cell = "c2", the output should be 6.

Input/Output
[input] string cell

String consisting of letter+number - coordinates of the knight on an 8 × 8 chessboard in chess notation.

[output] an integer
*/

using System.Linq;

namespace CodeWars
{
    public class ChessFun3ChessKnight
    {
        public int ChessKnight(string cell)
        {
            //return 8 - 2 * cell.Sum(e => 1 >> e % 58 % 5) >> cell.Sum(e => 1 >> e % 62 % 7);

            int[] arr = {2, 3, 4, 4, 3, 4, 6, 6, 4, 6, 8, 8, 4, 6, 8, 8};
            var row = cell[0] - 97;
            if (row > 3) row = 7 - row;
            var col = int.Parse(cell[1].ToString()) - 1;
            if (col > 3) col = 7 - col;
            return arr[4 * row + col];
        }
    }
}