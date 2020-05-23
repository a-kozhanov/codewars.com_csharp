/*
https://www.codewars.com/kata/588810c99fb63e49e1000606/csharp

7 kyu
Simple Fun #38: House Of Cats

Task
There are some people and cats in a house. You are given the number of legs they have all together. 
Your task is to return an array containing every possible number of people that could be in the house sorted in ascending order. 
It's guaranteed that each person has 2 legs and each cat has 4 legs.

Example
For legs = 6, the output should be [1, 3].

There could be either 1 cat and 1 person (4 + 2 = 6) or 3 people (2 * 3 = 6).

For legs = 2, the output should be [1].

There can be only 1 person.

Input/Output
[input] integer legs

The total number of legs in the house.

Constraints: 2 ≤ legs ≤ 100.

[output] an integer array

Every possible number of people that can be in the house.
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class SimpleFun38HouseOfCats
    {
        public int[] HouseOfCats(int legs)
        {
            // var result = new List<int>();
            // for (var i = legs % 4 / 2; i <= legs / 2 + 1; i += 2)
            // {
            //     result.Add(i);
            // }
            // return result.ToArray();

            //return Enumerable.Range(legs % 4 / 2, legs / 2 + 1).Where(i => (i - legs % 4 / 2) % 2 == 0).ToArray();
            //return Enumerable.Range(0, (legs >> 2) + 1).Select(n => (n << 1) + ((legs & 2) >> 1)).ToArray();
            //return Enumerable.Range(0, legs / 2 + 1).Where(x => (legs - x * 2) % 4 == 0).ToArray();
            //return Enumerable.Range(0, legs / 2 + 1).Where(x => x % 2 == legs / 2 % 2).ToArray();
            return Enumerable.Range(0, legs / 4 + 1).Select(x => 2 * x + legs % 4 / 2).ToArray();
        }
    }
}