/*
https://www.codewars.com/kata/581d2647b2d02e33be000094/csharp

7 kyu
Getting to know LINQ

In .NET the Language Integrated Query (LINQ) component adds several helpful methods that can be used with enumerables.

The goal of this Kata is to practice some scenarios where LINQ can be used to replace loops.

Replace each loop in the code with a LINQ expression. The validation will fail if the words 'for' or 'while' occurs anywhere in the code (even in comments).
*/

using System.Linq;

namespace CodeWars
{
    public class GettingToKnowLINQ
    {
        public static int Sum(int[] integers) => integers.Sum();
        public static int CountChar(char[] chars, char charToCount) => chars.Count(c => charToCount == c);

        public static int[] CalculateSquares(int start, int end) =>
            Enumerable.Range(start, end - start + 1).Select(i => i * i).ToArray();

        public static int[] CalculateSquares2(int start, int end) =>
            new int[end - start + 1].Select(i => start * start++).ToArray();
    }
}