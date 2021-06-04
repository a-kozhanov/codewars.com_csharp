/*
https://www.codewars.com/kata/57a1d5ef7cb1f3db590002af/csharp

7 kyu
Fibonacci

Create function fib that returns n'th element of Fibonacci sequence (classic programming task).
*/

using System;

namespace CodeWars
{
    public class Fibonacci
    {
        public static int fib(int n)
        {
            return n < 2 ? n : fib(n - 1) + fib(n - 2);
            // return n > 1 ? fib(n - 1) + fib(n - 2) : n;
        }
    }
}