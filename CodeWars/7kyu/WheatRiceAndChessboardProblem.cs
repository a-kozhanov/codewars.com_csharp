/*
https://www.codewars.com/kata/5b0d67c1cb35dfa10b0022c7/csharp

7 kyu
The wheat/rice and chessboard problem

I assume most of you are familiar with the ancient legend of the rice (but I see wikipedia suggests wheat, for some reason) problem, 
but a quick recap for you: a young man asks as a compensation only 1 grain of rice for the first square, 2 grains for the second, 
4 for the third, 8 for the fourth and so on, always doubling the previous.

Your task is pretty straightforward (but not necessarily easy): given an amount of grains, 
you need to return up to which square of the chessboard one should count in order to get at least as many.

As usual, a few examples might be way better than thousands of words from me:

SquaresNeeded(0) == 0
SquaresNeeded(1) == 1
SquaresNeeded(2) == 2
SquaresNeeded(3) == 2
SquaresNeeded(4) == 3
Input is always going to be valid/reasonable: ie: a non negative number; 
extra cookie for not using a loop to compute square-by-square (at least not directly) and instead trying a smarter approach [hint: some peculiar operator]; 
a trick converting the number might also work: impress me!

*/

using System;

namespace CodeWars
{
    public class WheatRiceAndChessboardProblem
    {
        public static int SquaresNeeded(long grains)
        {
            return (int) Math.Ceiling(Math.Log(grains + 1, 2));
            //return grains > 0 ? 1 + SquaresNeeded(grains / 2) : 0;
            //return grains > 0 ? (int) Math.Floor(Math.Log(grains, 2)) + 1 : 0;
        }
    }
}