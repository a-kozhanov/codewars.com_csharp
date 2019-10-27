
//https://www.codewars.com/kata/count-the-number-of-cubes-with-paint-on/train/csharp
//https://www.codewars.com/kata/5763bb0af716cad8fb000580/solutions/csharp

//Count the number of cubes with paint on
//8 kyu

//Upon arriving at an interview, you are presented with a solid blue cube.
//The cube is then dipped in red paint, coating the entire surface of the cube. The interviewer then proceeds to cut through the cube in all three dimensions a certain number of times.
//The number of times that the cube is cut in each dimension --> the argument 'cuts'.
//To solve the puzzle you must create a function that returns an integer representing the total number of small cubes with at least one red side.
//Examples:
//countSquares(2) --> 26
//countSquares(4) --> 98


using System;

namespace CodeWars
{
    public class CountNumberCubes
    {
        public static int CountSquares(int cuts)
        {
            //return (cuts != 0) ? (int)(6 * Math.Pow(cuts, 2) + 2) : 1;
            return (int)(6 * Math.Pow(cuts, 2) + 2);
        }

        //public static int CountSquares(int n)
        //{
        //    return n == 0 ? 1 : 6 * n * n + 2;
        //}




    }
}