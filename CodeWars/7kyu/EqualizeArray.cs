/*
https://www.codewars.com/kata/580a1a4af195dbc9ed00006c/csharp

7 kyu
Equalize the array!

No description!!!

Input :: [10,20,25,0]
Output :: ["+0", "+10", "+15", "-10"]

Show some love, rank and upvote!
*/


using System.Linq;

namespace CodeWars
{
    public class EqualizeArray
    {
        public static string[] Equalize(int[] array)
        {
            //return array.Select(i => (i - array[0]).ToString("+#;-#;+0")).ToArray();
            //return array.Select(i => (i - array[0]).ToString("+0;-#")).ToArray();
            return array.Select(i => $"{i - array[0]:+0;-#}").ToArray();
        }
    }
}