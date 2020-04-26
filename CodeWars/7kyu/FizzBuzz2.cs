/*
https://www.codewars.com/kata/5300901726d12b80e8000498/train/csharp

7 kyu
Fizz Buzz

Return an array containing the numbers from 1 to N, where N is the parametered value. 
N will never be less than 1 (in C#, N might be less than 1).

C# ONLY: If N is smaller than or equal to 0, throw an ArgumentOutOfRangeException!
Replace certain values however if any of the following conditions are met:

If the value is a multiple of 3: use the value 'Fizz' instead
If the value is a multiple of 5: use the value 'Buzz' instead
If the value is a multiple of 3 & 5: use the value 'FizzBuzz' instead
C# method calling example:

string[] result = FizzBuzz.GetFizzBuzzArray(3); // => [ "1", "2", "Fizz" ]
*/


using System;
using System.Linq;

namespace CodeWars
{
    public class FizzBuzz2
    {
        public static string[] GetFizzBuzzArray(int n)
        {
            return n > 0
                ? Enumerable.Range(1, n)
                    .Select(x => x % 15 == 0 ? "FizzBuzz" : x % 3 == 0 ? "Fizz" : x % 5 == 0 ? "Buzz" : $"{x}")
                    .ToArray()
                : throw new ArgumentOutOfRangeException();


            return n < 1
                ? throw new ArgumentOutOfRangeException()
                : Enumerable.Range(1, n)
                    .Select(x => x % 15 == 0 ? "FizzBuzz" : x % 3 == 0 ? "Fizz" : x % 5 == 0 ? "Buzz" : $"{x}")
                    .ToArray();

            // return n == 0
            //     ? throw new ArgumentOutOfRangeException()
            //     : Enumerable.Range(1, n)
            //         .Select(x =>
            //             x % 3 == 0 && x % 5 == 0 ? "FizzBuzz" : x % 3 == 0 ? "Fizz" : x % 5 == 0 ? "Buzz" : $"{x}")
            //         .ToArray();
        }
    }
}