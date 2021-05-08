/*
https://www.codewars.com/kata/5b7bd90ef643c4df7400015d/csharp

7 kyu
Create palindrome

Consider the string "adfa" and the following rules:

a) each character MUST be changed either to the one before or the one after in alphabet. 
b) "a" can only be changed to "b" and "z" to "y". 
From our string, we get:

"adfa" -> ["begb","beeb","bcgb","bceb"]

Here is another example: 
"bd" -> ["ae","ac","ce","cc"]

--We see that in each example, one of the outcomes is a palindrome. That is, "beeb" and "cc".
You will be given a lowercase string and your task is to return True if at least one of the outcomes is a palindrome or False otherwise.

More examples in test cases. Good luck!
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class CreatePalindrome
    {
        public static bool solve(string st)
        {
            //return st.Zip(st.Reverse(), (a, z) => a - z + 2).All(x => (x & 6) == x);

            return st.Reverse().Zip(st, (x, y) => x - y).All(i => i == 0 || i == 2 || i == -2);

            // return st.Take(st.Length / 2).Zip(st.Reverse().Take(st.Length / 2))
            //     .All(x => new[] {0, 2, -2}.Contains(x.First - x.Second));

            // return Enumerable.Range(0, st.Length / 2)
            //     .Select(i => Math.Abs(st[i] - st[st.Length - i - 1]))
            //     .All(x => x == 0 || x == 2);
        }
    }
}