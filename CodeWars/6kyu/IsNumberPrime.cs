/*
https://www.codewars.com/kata/5262119038c0985a5b00029f/csharp

6 kyu
Is a number prime?

Define a function that takes one integer argument and returns logical value true or false depending on if the integer is a prime.

Per Wikipedia, a prime number (or a prime) is a natural number greater than 1 that has no positive divisors other than 1 and itself.

Requirements
You can assume you will be given an integer input.
You can not assume that the integer will be only positive. You may be given negative numbers as well (or 0).
NOTE on performance: There are no fancy optimizations required, but still the most trivial solutions might time out. 
Numbers go up to 2^31 (or similar, depends on language version). Looping all the way up to n, or n/2, will be too slow.

Example
is_prime(1)  false 
is_prime(2)   true  
is_prime(-1)  false 
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class IsNumberPrime
    {
        public static bool IsPrime(int n)
        {
            return n > 1 && Enumerable.Range(2, (int) Math.Sqrt(n) - 1).All(i => n % i != 0);
            //return n > 1 && (n <= 3 || Enumerable.Range(2, (int) Math.Sqrt(n)).All(i => n % i != 0));
        }
    }
}