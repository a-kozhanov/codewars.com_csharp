
//https://www.codewars.com/kata/remove-string-spaces/train/csharp
//https://www.codewars.com/kata/57eae20f5500ad98e50002c5/solutions/csharp

//Remove String Spaces

//Simple, remove the spaces from the string, then return the resultant string.

using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class RemoveStringSpaces
    {
        public static string NoSpace(string input)
        {
            return input.Replace(" ", "");
        }

        //public static string NoSpace(string input)
        //{
        //    return input.Replace(" ", string.Empty);
        //}


        //public static string NoSpace(string input)
        //{
        //    return new string(input.ToCharArray()
        //        .Where(c => !char.IsWhiteSpace(c))
        //        .ToArray());
        //}

        //public static string NoSpace(string s)
        //{
        //    return new string(s.ToCharArray().Where(c => !Char.IsWhiteSpace(c)).ToArray());
        //}


        //public static string NoSpace(string input)
        //{
        //    return input = Regex.Replace(input, @"\s+", "");
        //}

        //public static string NoSpace(string input)
        //{
        //    return new Regex("[ ]?").Replace(input, "");
        //}

        //public static string NoSpace(string input)
        //{
        //    //Code it!
        //    string[] arr1 = input.Split(' ');
        //    return string.Join("", arr1);
        //}


        //public static string NoSpace(string input)
        //{
        //    return string.Concat(input.Split());
        //}


        //public static string NoSpace(string input)
        //{
        //    return string.Join("", input.Split(' '));
        //}




    }
}