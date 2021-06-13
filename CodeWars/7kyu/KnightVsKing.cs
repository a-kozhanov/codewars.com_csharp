/*
https://www.codewars.com/kata/564e1d90c41a8423230000bc/csharp

7 kyu
Knight vs King

Knight vs King
If you are not familiar with chess game you can learn more Here .

Here is the chess board:

alt text

You put a Knight and a king in the board.

Complete the method that tell us which one can capture the other one.

public static string KnightVsKing(object[] knightPosition, object[]kingPosition)
        {
        // Three possible outputs are "Knight", "King" and "None".
        }
You are provided with two object array; each contains an integer (first item) and a string (second item) to show the position of the pieces in the chess board.

object[] kingPosition = {4, "C"};
object[] knightPosition = {6, "D"};
Check the test cases and Happy coding :)
*/

using System;

namespace CodeWars
{
    public class KataKnightVsKing
    {
        public static string KnightVsKing(object[] knightPosition, object[] kingPosition)
        {
            var x = (int) knightPosition[0] - (int) kingPosition[0];
            var y = ((string) knightPosition[1])[0] - ((string) kingPosition[1])[0];
            var d = x * x + y * y;
            return d < 3 ? "King" : d == 5 ? "Knight" : "None";

            // var x = Math.Abs((int) knightPosition[0] - (int) kingPosition[0]);
            // var y = Math.Abs(((string) knightPosition[1])[0] - ((string) kingPosition[1])[0]);
            // var d = x + y;
            // return d > 3 ? "None" : d == 3 ? "Knight" : "King";

            // var x = Math.Abs((int) knightPosition[0] - (int) kingPosition[0]);
            // var y = Math.Abs(((string) knightPosition[1])[0] - ((string) kingPosition[1])[0]);
            // var d = x * x + y * y;
            // return d == 5 ? "Knight" : d <= 2 ? "King" : "None";
        }
    }
}