﻿/*
https://www.codewars.com/kata/54fb963d3fe32351f2000102/csharp

7 kyu
Collatz Conjecture Length

The Collatz Conjecture states that for any natural number n, if n is even, divide it by 2. 
If n is odd, multiply it by 3 and add 1. 
If you repeat the process continuously for n, n will eventually reach 1.

For example, if n = 20, the resulting sequence will be:

[20, 10, 5, 16, 8, 4, 2, 1]

Write a program that will output the length of the Collatz Conjecture for any given n. 
In the example above, the output would be 8.

For more reading see: http://en.wikipedia.org/wiki/Collatz_conjecture
*/

namespace CodeWars
{
    public class CollatzConjectureLength
    {
        public static int Collatz(int n)
        {
            var count = 1;
            while (n > 1)
            {
                count++;
                n = n % 2 == 0 ? n / 2 : n * 3 + 1;
            }

            return count;
        }
    }
}