/*
https://www.codewars.com/kata/51c7d8268a35b6b8b40002f2/csharp

7 kyu
Building Strings From a Hash

Complete the solution so that it takes the object (JavaScript/CoffeeScript) or hash (ruby) passed in and generates a human readable string from its key/value pairs.

The format should be "KEY = VALUE". Each key/value pair should be separated by a comma except for the last pair.

Example:
Kata.StringifyDict(new Dictionary<char, int> {{'a', 1}, {'b', 2}}) => "a = 1,b = 2";
*/

using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class BuildingStringsFromHash
    {
        public static string StringifyDict<TKey, TValue>(Dictionary<TKey, TValue> hash)
        {
            return string.Join(",", hash.Select(x => $"{x.Key} = {x.Value}"));
        }
    }
}