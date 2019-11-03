
/*
https://www.codewars.com/kata/is-it-even/train/csharp
https://www.codewars.com/kata/555a67db74814aa4ee0001b5/solutions/csharp

8 kyu
Is it even?

In this Kata we are passing a number (n) into a function.
Your code will determine if the number passed is even (or not).
The function needs to return either a true or false.
Numbers may be positive or negative, integers or floats.
Floats are considered UNeven for this kata.
*/


using System;

namespace CodeWars
{
    public class IsItEven
    {
        public bool IsEven(double n)
        {
            return n % 2 == 0;
        }

        //public bool IsEven(double n) => n % 2 == 0;


        //public bool IsEven(double n)
        //{
        //    return (n % 2 == 0) ? true : false;
        //}


        //public bool IsEven(double n) => n % 2 == 0;


        //public bool IsEven(double n)
        //{
        //    return (n is float) ? false : n % 2 == 0 ? true : false;
        //}


        //public bool IsEven(double n)
        //{
        //    return n % 1 == 0 && n % 2 == 0;
        //}

    }

}