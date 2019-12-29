/*
https://www.codewars.com/kata/54ba84be607a92aa900000f1

7 kyu
Isograms

An isogram is a word that has no repeating letters, consecutive or non-consecutive. 
Implement a function that determines whether a string that contains only letters is an isogram. 
Assume the empty string is an isogram. 
Ignore letter case.

isIsogram "Dermatoglyphics" == true
isIsogram "aba" == false
isIsogram "moOse" == false -- ignore letter case
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class Isograms
    {
        public static bool IsIsogram(string str)
        {
            //return !str.ToUpper().Any(x => str.ToUpper().Count(c => c == x) > 1);
            return str.ToUpper().Distinct().Count() == str.Length;
            //return new HashSet<char>(str.ToUpper()).Count == str.Length;
            //return !Regex.IsMatch(str, @"([a-z]).*\1", RegexOptions.IgnoreCase);
            //return str.ToUpper().GroupBy(s => s).All(s => s.Count() <= 1);
        }
    }
}