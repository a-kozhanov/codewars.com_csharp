using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//https://www.codewars.com/kata/is-the-string-uppercase/train/csharp
//https://www.codewars.com/kata/56cd44e1aa4ac7879200010b/solutions/csharp

//Is the string uppercase?

//Task
//Create a method isUpperCase to see whether the string is ALL CAPS.For example:

//isUpperCase("c") == False
//isUpperCase("C") == True
//isUpperCase("hello I AM DONALD") == False
//isUpperCase("HELLO I AM DONALD") == True
//isUpperCase("ACSKLDFJSgSKLDFJSKLDFJ") == False
//isUpperCase("ACSKLDFJSGSKLDFJSKLDFJ") == True


namespace CodeWars
{
    public static class StringExtensions
    {
        public static bool IsUpperCase(this string Obj)
        {
            return !Obj.ToCharArray().Any(char.IsLower);
        }


        //Best Practices
        //public static bool IsUpperCase(this string value)
        //{
        //    return value.ToUpper() == value;
        //}

        //public static bool IsUpperCase(this string s)
        //{
        //    return !s.Any(x => Char.IsLower(x));
        //}

        //public static bool IsUpperCase(this string str)
        //{
        //    return str == str.ToUpper();
        //}

        //public static bool IsUpperCase(this string s) => new List<char>(s).TrueForAll(x => !char.IsLower(x));

        //public static bool IsUpperCase(this string str)
        //{
        //    return !str.Any(x => char.IsLower(x));
        //}

        //public static bool IsUpperCase(this string s)
        //{
        //    return s.ToUpper() == s;
        //}

        //public static bool IsUpperCase(this string s)
        //{
        //    return s.ToUpper().Equals(s);
        //}

        //public static bool IsUpperCase(this string str) => str == str.ToUpper();

    }
}
