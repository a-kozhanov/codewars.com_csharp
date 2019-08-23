using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//https://www.codewars.com/kata/moves-in-squared-strings-i/train/csharp
//https://www.codewars.com/kata/56dbe0e313c2f63be4000b25/solutions/csharp

//This kata is the first of a sequence of four about "Squared Strings".

//You are given a string of n lines, each substring being n characters long: For example:

//s = "abcd\nefgh\nijkl\nmnop"

//We will study some transformations of this square of strings.

//Vertical mirror: vert_mirror (or vertMirror or vert-mirror)
//vert_mirror(s) => "dcba\nhgfe\nlkji\nponm"
//Horizontal mirror: hor_mirror (or horMirror or hor-mirror)
//hor_mirror(s) => "mnop\nijkl\nefgh\nabcd"
//or printed:

//vertical mirror   |horizontal mirror
//abcd --> dcba     |abcd --> mnop
//efgh hgfe     |efgh ijkl
//ijkl lkji     |ijkl efgh
//mnop ponm     |mnop abcd

//# Task:
//Write these two functions
//and

//high-order function oper(fct, s) where

//fct is the function of one variable f to apply to the string s (fct will be one of vertMirror, horMirror)
//#Examples:

//s = "abcd\nefgh\nijkl\nmnop"
//oper(vert_mirror, s) => "dcba\nhgfe\nlkji\nponm"
//oper(hor_mirror, s) => "mnop\nijkl\nefgh\nabcd"
//Note:
//The form of the parameter fct in oper changes according to the language. You can see each form according to the language in "Sample Tests".

//Bash Note:
//The input strings are separated by , instead of \n. The ouput strings should be separated by \r instead of \n. See "Sample Tests".

//Forthcoming katas will study other tranformations.

namespace CodeWars
{
    public static class MovesSquaredStrings
    {
        //vertical mirror
        //abcd\nefgh\nijkl\nmnop -> dcba\nhgfe\nlkji\nponm
        //abcd dcba 
        //efgh hgfe 
        //ijkl lkji
        //mnop ponm

        public static string VertMirror(string s)
        {
            return string.Join("\n", s.Split("\n").Select(c => new string(c.Reverse().ToArray())));
        }

        //horizontal mirror
        //abcd\nefgh\nijkl\nmnop -> mnop\nijkl\nefgh\nabcd
        //abcd mnop
        //efgh ijkl
        //ijkl efgh
        //mnop abcd

        public static string HorMirror(string s)
        {
            return string.Join("\n", s.Split("\n").Reverse());
        }

        public static string Oper(Func<string, string> fct, string s)
        {
            return fct(s);
        }

        //        Best Practices
        //        public static string VertMirror(string strng)
        //        {
        //            return string.Join("\n", strng.Split('\n').Select(i => string.Concat(i.Reverse())));
        //        }
        //        public static string HorMirror(string strng)
        //        {
        //            return string.Join("\n", strng.Split('\n').Reverse());
        //        }
        //        public static string Oper(Func<string, string> fct, string s)
        //        {
        //            return fct(s);
        //        }

    }
}
