/*
https://www.codewars.com/kata/552c028c030765286c00007d/csharp

6 kyu
IQ Test

Bob is preparing to pass IQ test. 
The most frequent task in this test is to find out which one of the given numbers differs from the others. 
Bob observed that one number usually differs from the others in evenness. 
Help Bob — to check his answers, he needs a program that among the given numbers finds one that is different in evenness, 
and return a position of this number.

! Keep in mind that your task is to help Bob solve a real IQ test, which means indexes of the elements start from 1 (not 0)

##Examples :
IQ.Test("2 4 7 8 10") => 3 // Third number is odd, while the rest of the numbers are even
IQ.Test("1 2 1 1") => 2 // Second number is even, while the rest of the numbers are odd
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class IQTest
    {
        public static int Test(string numbers)
        {
            return numbers.Split().Select((s, i) => new {isEven = int.Parse(s) % 2, Index = i + 1})
                .GroupBy(x => x.isEven).First(x => x.Count() == 1).Select(x => x.Index).First();
        }
    }
}