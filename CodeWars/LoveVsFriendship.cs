/*
https://www.codewars.com/kata/59706036f6e5d1e22d000016/train/csharp
https://www.codewars.com/kata/59706036f6e5d1e22d000016/solutions/csharp

7 kyu
Love vs friendship

If　a = 1, b = 2, c = 3 ... z = 26
Then l + o + v + e = 54
and f + r + i + e + n + d + s + h + i + p = 108
So friendship is twice stronger than love :-)
The input will always be in lowercase and never be empty.
*/

using System.Linq;

namespace CodeWars
{
    public class LoveVsFriendship
    {
        public static int WordsToMarks(string str)
        {
            return str.Sum(c => c - 96);
        }


        // public static int WordsToMarks(string str)
        // {
        //     int sum = 0;
        //     // 'a' has 97 int representation in Unicode table, so we minus 96 to get 'a' equal to 1
        //     int charSpace = 96;
        //
        //     foreach (char letter in str)
        //     {
        //         sum += letter - charSpace;
        //     }
        //
        //     return sum;
        // }


        // public static int WordsToMarks(string str)
        // {
        //     int sum = 0;
        //     foreach (char c in str) sum += Convert.ToInt32(c) - 96;
        //     return sum;
        // }


        // public static int WordsToMarks(string str)
        // {
        //     int result = 0;
        //     string alphabet = "abcdefghijklmnopqrstuvwxyz";
        //     foreach (char c in str.ToLower())
        //     {
        //         int x = alphabet.IndexOf(c) + 1;
        //         result += x;
        //     }
        //
        //     return result;
        // }


        // public static int WordsToMarks(string str)
        // {
        //     var ch = "abcdefghijklmnopqrstuvwxyz";
        //     return str.Select(x => ch.IndexOf(x.ToString().ToLower()) + 1).Sum();
        // }


        // public static class Kata
        // {
        //     public static int WordsToMarks(string str)
        //     {
        //         int sum = 0;
        //         foreach (var item in str)
        //         {
        //             sum += item - 96;
        //         }
        //
        //         return sum;
        //     }
        // }


        // public static int WordsToMarks(string str) => str.Aggregate(0,(result, item) => result + (int)item-96);


        // public static int WordsToMarks(string str)
        // {
        //     int count = 0;
        //     foreach (char c in str)
        //     {
        //         count += (c - 'a') + 1;
        //     }
        //     return count;
        // }
    }
}