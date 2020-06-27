/*
https://www.codewars.com/kata/566efcfbf521a3cfd2000056/csharp

7 kyu
Reversing Fun

You are going to be given a string. Your job is to return that string in a certain order that I will explain below:

Let's say you start with this: 012345

The first thing you do is reverse it:543210
Then you will take the string from the 1st position and reverse it again:501234
Then you will take the string from the 2nd position and reverse it again:504321
Then you will take the string from the 3rd position and reverse it again:504123

Continue this pattern until you have done every single position, and then you will return the string you have created. 
For this particular number, you would return:504132

#Input: A string of length 1 - 1000

#Output: A correctly reordered string.
*/

using System.Linq;

namespace CodeWars
{
    public class ReversingFun
    {
        public static string FlipNumber(string n)
        {
            //return string.Concat(Enumerable.Range(0, n.Length / 2 + 1).Select(x => "" + n[n.Length - x - 1] + n[x])).Substring(0, n.Length);
            //return Enumerable.Range(0, n.Length - 1).Select((x, i) => n = string.Concat(n.Take(i).Concat(n.Skip(i).Reverse()))).Last();
            //return Enumerable.Range(0, n.Length - 1).Select((x, i) => n = n[..i] + string.Concat(n[i..].Reverse())).Last();
            return $"{n.Last()}{(n.Length > 1 ? FlipNumber(string.Concat(n[..^1].Reverse())) : "")}";
        }
    }
}