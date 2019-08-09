using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{

    //https://www.codewars.com/kata/count-characters-in-your-string/train/csharp
    //

    //The main idea is to count all the occuring characters(UTF-8) in string.
    //If you have string like this aba then the result should be { 'a': 2, 'b': 1 }

    //What if the string is empty? Then the result should be empty object literal { }
    //For C#: Use a Dictionary<char, int> for this kata!

    public class CountCharacters
    {
        public static Dictionary<char, int> Count(string str)
        {
            var result = new Dictionary<char, int>();

            foreach (var uniqueChar in str.Distinct())
            {
                var countChar = 0;
                foreach (var ch in str)
                    if (uniqueChar == ch) countChar++;
                result.Add(uniqueChar, countChar);
            }

            return result;
        }
    }
}