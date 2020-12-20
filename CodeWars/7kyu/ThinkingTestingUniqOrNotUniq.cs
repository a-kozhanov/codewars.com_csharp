/*
https://www.codewars.com/kata/56d949281b5fdc7666000004/csharp

7 kyu
Thinking & Testing : Uniq or not Uniq

No Story
No Description
Only by Thinking and Testing
Look at result of testcase, guess the code!
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class ThinkingTestingUniqOrNotUniq
    {
        public int[] Testit(int[] a, int[] b)
        {
            //return Enumerable.Concat(a.Distinct(), b.Distinct()).OrderBy(i => i).ToArray();
            return a.Distinct().Concat(b.Distinct()).OrderBy(i => i).ToArray();
        }
    }
}