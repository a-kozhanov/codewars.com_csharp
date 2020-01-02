/*
https://www.codewars.com/kata/draw-stairs/train/csharp
https://www.codewars.com/kata/5b4e779c578c6a898e0005c5/solutions/csharp

8 kyu
Draw stairs

Given a number n, draw stairs using the letter "I", n tall and n wide, with the tallest in the top left.

For example n = 3 result in "I\n I\n I", or printed:

I
 I
  I
Another example, a 7-step stairs should be drawn like this:

I
 I
  I
   I
    I
     I
      I
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class KataDrawStairs
    {
        public static string DrawStairs(int n)
        {
            //return string.Join("\n", Enumerable.Repeat("I", n).Select((v, i) => new string(' ', i) + v));
            //return string.Join("\n", new string('I', n).Select((v, i) => v.ToString().PadLeft(i + 1)));
            //return string.Join('\n', Enumerable.Range(1, n).Select("I".PadLeft));
            //return string.Join("\n", Enumerable.Repeat("I", n).Select((v, i) => v.PadLeft(i + 1)));
            //return string.Join("\n", Enumerable.Range(0, n).Select(x => new string(' ', x) + "I"));
            return string.Join("\n ", Enumerable.Repeat("I", n).Select((s, i) => s.PadLeft(i)));
        }
    }
}