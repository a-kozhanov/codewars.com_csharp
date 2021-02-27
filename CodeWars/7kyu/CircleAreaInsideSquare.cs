/*
https://www.codewars.com/kata/5899aa695401a83a5c0000c4/csharp

7 kyu
Circle area inside square

Circle area inside square
Turn an area of a square in to an area of a circle that fits perfectly inside the square.

Example

You get the blue+red area and need to calculate the red area.

Your function gets a number which represents the size of the square and should return the size of the circle. 
The tests are rounded by 8 decimals to make sure multiple types of solutions work.

squareAreaToCircle(16); //should return size of the circle
You don't have to worry about error handling or negative number input: size >= 0.

This kata might be simpler than you expect, but good luck!
*/

using System;

namespace CodeWars
{
    public class CircleAreaInsideSquare
    {
        public static double SquareAreaToCircle(double size)
        {
            return Math.PI * size / 4;
            //return size * 0.785398163397448;
            //return Math.Pow(0.5 * Math.Sqrt(size), 2) * Math.PI;
            //return 3.1415926535897932384626433832795 * size / 4;
        }
    }
}