/*
https://www.codewars.com/kata/57d2ba8095497e484e00002e/train/csharp
https://www.codewars.com/kata/57d2ba8095497e484e00002e/solutions/csharp

7 kyu
Borrower Speak

The borrowers are tiny tiny fictional people. 
As tiny tiny people they have to be sure they aren't spotted, or more importantly, stepped on.
As a result, the borrowers talk very very quietly. 
They find that capitals and punctuation of any sort lead them to raise their voices and put them in danger.
The young borrowers have begged their parents to stop using caps and punctuation.
Change the input text 's' to new borrower speak. Help save the next generation!
*/

using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class BorrowerSpeak
    {
        public static string Borrow(string s)
        {
            return Regex.Replace(s.ToLower(), "\\W*", "");
        }

        // public static string Borrow(string s) => Regex.Replace(s, @"[^\w]", "").ToLower();


        // public static string Borrow(string s)
        // {
        //     return string.Concat(s.ToLower().Where(c => c >= 'a' && c <= 'z'));
        // }

        // public class Kata
        // {
        //     public static string Borrow(string s) => string.Concat(s.Where(char.IsLetter)).ToLower();
        // }

        // public static string Borrow(string s)
        // {
        //     return string.Concat(s.Select(c => Char.IsLetter(c)? c.ToString().ToLower(): ""));
        // }

        // public static string Borrow(string s) => string.Concat(s.ToLower().Where(char.IsLetter));

        // public static string Borrow(string s)
        // {
        //     return string.Concat(s.Where(char.IsLetter)).ToLower();
        // }
    }
}