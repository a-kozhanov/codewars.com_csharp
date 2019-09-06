using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


//https://www.codewars.com/kata/is-there-a-vowel-in-there/train/csharp
//https://www.codewars.com/kata/57cff961eca260b71900008f/solutions/csharp

//Is there a vowel in there?

//Given an array of numbers, check if any of the numbers are the character codes for lower case vowels(a, e, i, o, u).
//If they are, change the array value to a string of that vowel.
//Return the resulting array.


namespace CodeWars
{
    public class IsThereVowel
    {
        public static object[] IsVow(object[] a)
        {
            var vowelCodes = new HashSet<int> { 'a', 'e', 'i', 'o', 'u' };
            var result = new List<object>();
            foreach (int i in a)
                if (vowelCodes.Contains(i))
                    result.Add(Convert.ToChar(i).ToString());
                else
                    result.Add(i);
            return result.ToArray();
        }

        //public static object[] IsVow(object[] a)
        //{
        //    return a.Select(x => "aeiou".Contains(Convert.ToChar(x)) ? Convert.ToChar(x).ToString() : x).ToArray();
        //}


        //public static object[] IsVow(object[] a)
        //{
        //    return a.Select(b => (int)b == 101 ? "e" : (int)b == 97 ? "a" : (int)b == 117 ? "u" : (int)b == 111 ? "o" : (int)b == 105 ? "i" : b).ToArray();
        //}

        //public static object[] IsVow(object[] a)
        //{
        //    List<char> strings = new List<char> { 'a', 'e', 'i', 'o', 'u' };
        //    List<object> result = new List<object>();

        //    foreach (var val in a)
        //    {
        //        if (strings.Contains(Convert.ToChar(val)))
        //        {
        //            result.Add(Convert.ToChar(val).ToString());
        //        }
        //        else
        //        {
        //            result.Add(val);
        //        }
        //    }
        //    return result.ToArray();
        //}


        //public static object[] IsVow(object[] a)
        //{
        //    return a.Select(x =>
        //    {
        //        var ch = (char)(int)x;
        //        return "aeiou".Contains(ch) ? ch.ToString() : x;

        //    }).ToArray();
        //}


        //public static object[] IsVow(object[] a)
        //{
        //    return a.Select(c => Regex.IsMatch((Convert.ToChar(c)).ToString(), "[aeiou]") ? (Convert.ToChar(c)).ToString() : c).ToArray();
        //}


        //public static object[] IsVow(object[] a)
        //{
        //    char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
        //    return a.Select(n => vowels.Contains((char)(int)n) ? new string((char)(int)n, 1) : n).ToArray();
        //}





    }
}
