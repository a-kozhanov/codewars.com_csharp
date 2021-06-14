/*
https://www.codewars.com/kata/564e22e30e686c7f7e00005d/csharp

7 kyu
Knight vs Rook

Knight vs Rook
If you are not familiar with chess game you can learn more Here .

Here is the chess board:

alt text

You put a Knight and a Rook in the board.

Complete the method that tell us which one can capture the other one.

public static string KnightVsRook(object[] knightPosition, object[]rookPosition)
        {
        // Three possible outputs are "Knight", "Rook" and "None".
        }
You are provided with two object array; each contains an integer (first item) and a string (second item) to show the position of the pieces in the chess board.

object[] rookPosition = {4, "C"};
object[] knightPosition = {6, "D"};
Check the test cases and Happy coding :)
*/

using System;

namespace CodeWars
{
    public static class KataKnightVsRook
    {
        public static string KnightVsRook(object[] knightPosition, object[] rookPosition)
        {
            var x = Math.Abs((int) knightPosition[0] - (int) rookPosition[0]);
            var y = Math.Abs(((string) knightPosition[1])[0] - ((string) rookPosition[1])[0]);
            return x == 0 || y == 0 ? "Rook" : x + y == 3 ? "Knight" : "None";
        }
    }
}