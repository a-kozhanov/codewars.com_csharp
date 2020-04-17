/*
https://www.codewars.com/kata/52e9aa89b5acdd26d3000127/train/csharp

7 kyu
Multiply characters

Here we have a function that help us spam our hearty laughter. But is not working! I need you to find out why...

Expected results:

Kata.Spam(1)  => "hue";
Kata.Spam(6)  => "huehuehuehuehuehue";
Kata.Spam(14) => "huehuehuehuehuehuehuehuehuehuehuehuehuehue";
*/

using System.Linq;
using System.Text;

namespace CodeWars
{
    public class MultiplyCharacters
    {
        public static string Spam(int n, string s = "hue")
        {
            //return new StringBuilder(s.Length * n).AppendJoin(s, new string[n + 1]).ToString();
            //return new StringBuilder(s.Length * n).Insert(0, s, n).ToString();
            //return string.Concat(Enumerable.Repeat("hue", n));
            //return "".PadLeft(n, '#').Replace("#", "hue");
            return new string('#', n).Replace("#", "hue");
        }
    }
}