/*
https://www.codewars.com/kata/539ee3b6757843632d00026b/train/csharp
https://www.codewars.com/kata/539ee3b6757843632d00026b/solutions/csharp

7 kyu
Find the capitals

Instructions
Write a function that takes a single string (word) as argument. 
The function must return an ordered list containing the indexes of all capital letters in the string.

Example
Assert.AreEqual(Kata.Capitals("CodEWaRs"), new int[]{0,3,4,6});
*/

using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class FindCapitals
    {
        public static int[] Capitals(string word)
        {
            //return word.Select((x, i) => char.IsUpper(x) ? i : -1).Where(x => x >= 0).ToArray();
            return Enumerable.Range(0, word.Length).Where(i => char.IsUpper(word, i)).ToArray();
            //return Regex.Matches(word, "[A-Z]").Select(m => m.Index).ToArray();
        }
    }
}