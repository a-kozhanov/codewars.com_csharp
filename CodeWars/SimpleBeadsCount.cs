/*
https://www.codewars.com/kata/58712dfa5c538b6fc7000569/train/csharp

7 kyu
Simple beads count

Two red beads are placed between every two blue beads. There are N blue beads. 
After looking at the arrangement below work out the number of red beads.

@ @@ @ @@ @ @@ @ @@ @ @@ @

Implement count_red_beads(n) (in PHP count_red_beads($n); in Java, Javascript, 
TypeScript, C, C++ countRedBeads(n)) so that it returns the number of red beads.
If there are less than 2 blue beads return 0.
*/


using System;

namespace CodeWars
{
    public class SimpleBeadsCount
    {
        public static int CountRedBeads(int n)
        {
            //return n < 2 ? 0 : n + (n - 2);
            //return n < 2 ? 0 : 2 * (n - 1);
            //return n > 1 ? (n - 1) * 2 : 0;
            //return n > 0 ? 2 * (n - 1) : 0;
            //return n != 0 ? (n - 1) * 2 : 0;
            //return n < 2 ? 0 : 2 * (n - 1);
            //return Math.Max(0, 2 * n - 2);
            //return n == 0 ? 0 : n * 2 - 2;
            //return n > 1 ? 2 * n - 2 : 0;
            //return n < 2 ? 0 : 2 * n - 2;
            //return n > 1 ? 2 * n - 2 : 0;
            //return n > 1 ? 2 * n - 2 : 0;
            //return n < 2 ? 0 : 2 * n - 2;
            //return n > 1 ? 2 * n - 2 : 0;

            return n > 0 ? (n - 1) * 2 : 0;
        }
    }
}