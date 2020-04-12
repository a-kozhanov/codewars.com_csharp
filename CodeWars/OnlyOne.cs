/*
https://www.codewars.com/kata/5734c38da41454b7f700106e/train/csharp

7 kyu
Only one

Given any number of boolean flags function should return true if and only if one of them is true while others are false. 
If function is called without arguments it should return false.

onlyOne() --> false
onlyOne(true, false, false) --> true
onlyOne(true, false, false, true) --> false
onlyOne(false, false, false, false) --> false  
*/

using System.Linq;

namespace CodeWars
{
    public class KataOnlyOne
    {
        public static bool OnlyOne(params bool[] flags)
        {
            //return flags.Sum(i => i ? 1 : 0) == 1;
            //return flags.Max(i => i ? 1 : 0) == 1;
            //return flags.Count(b => b).Equals(1);
            return flags.Count(b => b) == 1;
        }
    }
}