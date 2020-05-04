/*
https://www.codewars.com/kata/5650ab06d11d675371000003/train/csharp

7 kyu
Split In Parts

The aim of this kata is to split a given string into different strings of equal size (note size of strings is passed to the method)

Example:

Split the below string into other strings of size #3

'supercalifragilisticexpialidocious'

Will return a new string
'sup erc ali fra gil ist ice xpi ali doc iou s'
Assumptions:

String length is always greater than 0
String has no spaces
Size is always positive
*/


using System.Text.RegularExpressions;

namespace CodeWars
{
    public class KataSplitInParts
    {
        public static string SplitInParts(string s, int partLength)
        {
            //return Regex.Replace(s, string.Format(".{{{0}}}(?!$)", partLength), "$0 ");
            //return new Regex(new string('.', partLength)).Replace(s, "$0 ").Trim();
            //return string.Join(" ", Regex.Matches(s, $".{{1,{partLength}}}"));
            //return new Regex($".{{1,{partLength}}}").Replace(s, "$0 ").Trim();
            //return string.Join(" ", Regex.Matches(s, $".{{1,{partLength}}}"));
            //return Regex.Replace(s, "(.{" + partLength + "})", "$1 ").Trim();
            return Regex.Replace(s, $"(.{{{partLength}}})", "$1 ").Trim();
        }
    }
}