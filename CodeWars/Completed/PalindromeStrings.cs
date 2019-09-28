using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

//https://www.codewars.com/kata/57a5015d72292ddeb8000b31
//https://www.codewars.com/kata/57a5015d72292ddeb8000b31/solutions/csharp

//Palindrome Strings

//A palindrome is a word, phrase, number, or other sequence of characters which reads the same backward or forward.
//This includes capital letters, punctuation, and word dividers.
//Implement a function that checks if something is a palindrome.

//Examples
//isPalindrome("anna")   ==> true
//isPalindrome("walter") ==> false
//isPalindrome(12321)    ==> true
//isPalindrome(123456)   ==> false

namespace CodeWars
{
    public class PalindromeStrings
    {
        public static bool IsPalindrome(object line)
        {
            return line.ToString() == string.Concat(line.ToString().Reverse());
        }


        //public static bool IsPalindrome(object line) => line.ToString() == String.Join("", line.ToString().Reverse());


        //public static bool IsPalindrome(object o) => o.ToString().SequenceEqual(o.ToString().Reverse());


        //public static bool IsPalindrome(object line)
        //{
        //    string str = line.ToString();
        //    string reverseStr = new string(str.Reverse().ToArray());
        //    return str == reverseStr;
        //}


        //public static bool IsPalindrome(object line)
        //{
        //    char[] str = line.ToString().ToCharArray();
        //    char[] reverseStr = str.Reverse<char>().ToArray();
        //    return new string(str).Equals(new string(reverseStr));
        //}

        //public static bool IsPalindrome(object line)
        //{
        //    return line.ToString() == new String(line.ToString().ToCharArray().Reverse().ToArray());
        //}



    }

}
