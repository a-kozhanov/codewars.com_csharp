/*
https://www.codewars.com/kata/sort-the-gift-code/train/csharp
https://www.codewars.com/kata/52aeb2f3ad0e952f560005d3/solutions/csharp

7 kyu
Sort the Gift Code

Happy Holidays fellow Code Warriors!
Santa's senior gift organizer Elf developed a way to represent up to 26 gifts by assigning a unique alphabetical character to each gift. 
After each gift was assigned a character, the gift organizer Elf then joined the characters to form the gift ordering code.

Santa asked his organizer to order the characters in alphabetical order, 
but the Elf fell asleep from consuming too much hot chocolate and candy canes! 
Can you help him out?

Sort the Gift Code
Write a function called sortGiftCode/sort_gift_code/SortGiftCode that accepts a string containing up to 26 unique alphabetical characters, 
and returns a string containing the same characters in alphabetical order.

Examples:
Kata.SortGiftCode("abcdef") => "abcdef"
Kata.SortGiftCode("pqksuvy") => "kpqsuvy"
Kata.SortGiftCode("zyxwvutsrqponmlkjihgfedcba") => "abcdefghijklmnopqrstuvwxyz"
*/

using System.Linq;

namespace CodeWars
{
    public static class KataSortGiftCode
    {
        public static string SortGiftCode(string code)
        {
            return string.Concat(code.OrderBy(c => c));
        }

        // public static string SortGiftCode(string code)
        // {
        //     return string.Join("", code.OrderBy(v => v));
        // }


        // public static string SortGiftCode(string code)=>string.Concat(code.OrderBy(t=>(int)t));

        // public static string SortGiftCode(string code)
        // {
        //     return new String(code.ToCharArray().OrderBy(x => x).ToArray());
        // }
    }
}