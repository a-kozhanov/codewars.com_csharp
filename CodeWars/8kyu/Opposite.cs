using System;
using System.Linq;

//https://www.codewars.com/kata/they-say-that-only-the-name-is-long-enough-to-attract-attention-they-also-said-that-only-a-simple-kata-will-have-someone-to-solve-it-this-is-a-sadly-story-number-1-are-they-opposite/train/csharp
//https://www.codewars.com/kata/574b1916a3ebd6e4fa0012e7/solutions/csharp

//They say that only the name is long enough to attract attention. They also said that only a simple Kata will have someone to solve it. This is a sadly story #1: Are they opposite?
//8 kyu

//#Task
//    Give you two strings: s1 and s2. If they are opposite, return true; otherwise, return false. Note: The result should be a boolean value, instead of a string.

//    The opposite means: All letters of the two strings are the same, but the case is opposite. you can assume that the string only contains letters or it's a empty string. Also take note of the edge case - if both strings are empty then you should return false/False.

//#Some examples:
//    isOpposite("ab","AB") should return true;
//    isOpposite("aB","Ab") should return true;
//    isOpposite("aBcd","AbCD") should return true;
//    isOpposite("AB","Ab") should return false;
//    isOpposite("","") should return false;

namespace CodeWars
{
    public class Opposite
    {
        public static bool IsOpposite(string s1, string s2)
        {
            //return string.Empty != s1 ? s1.Equals(s2, StringComparison.OrdinalIgnoreCase) && s1.Equals(new string(s2.Select(c => char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c)).ToArray())) : false;
            //return string.Empty != s1 ? s1.Equals(new string(s2.Select(c => char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c)).ToArray())) : false;
            return s1 != "" && s1 == string.Concat(s2.Select(c => char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c)));
        }


        //public static bool IsOpposite(string s1, string s2)
        //    => string.IsNullOrEmpty(s1) ? false :   
        //        s1.SequenceEqual( s2.Select(e=>  Char.IsLower(e) ? Char.ToUpper(e) : Char.ToLower(e))); 


        //public static bool IsOpposite(string s1, string s2)
        //{  
        //    return s1 != string.Empty && string.Concat(s1.Select(x => char.IsLower(x) ? char.ToUpper(x): char.ToLower(x))) == s2;
        //}


        //public static bool IsOpposite(string s1, string s2)
        //{
        //    return s1 != "" && s1 != "" && string.Concat(s1.Select(x => char.IsUpper(x) ? char.ToLower(x) : char.ToUpper(x))) == s2;
        //}


        //public static bool IsOpposite(string s1, string s2)
        //{
        //    if (string.IsNullOrEmpty(s1) || string.IsNullOrEmpty(s2)) return false;
        //    return new string(s1.Select(x => char.IsLower(x) ? char.ToUpper(x) : char.ToLower(x)).ToArray()) == s2;
        //}




    }



}