/*
https://www.codewars.com/kata/54b81566cd7f51408300022d/csharp

7 kyu
Partial Word Searching

Write a method that will search an array of strings for all strings that contain another string, ignoring capitalization. 
Then return an array of the found strings.

The method takes two parameters, the query string and the array of strings to search, and returns an array.

If the string isn't contained in any of the strings in the array, 
the method returns an array containing a single string: "Empty" (or Nothing in Haskell, or "None" in Python and C)

Examples
If the string to search for is "me", and the array to search is ["home", "milk", "Mercury", "fish"], 
the method should return ["home", "Mercury"].
*/

using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class PartialWordSearching
    {
        public static string[] WordSearch(string query, string[] seq)
        {
            //return seq.Where(s => s.IndexOf(query, StringComparison.InvariantCultureIgnoreCase) >= 0).DefaultIfEmpty("Empty").ToArray();
            //return seq.Where(s => s.Contains(query, StringComparison.InvariantCultureIgnoreCase)).DefaultIfEmpty("Empty").ToArray();
            //return seq.Where(s => s.ToLower().IndexOf(query.ToLower()) >= 0).DefaultIfEmpty("Empty").ToArray();
            //return seq.Where(s => s.ToLower().Contains(query.ToLower())).DefaultIfEmpty("Empty").ToArray();
            return seq.Where(s => Regex.IsMatch(s, $"(?i){query}")).DefaultIfEmpty("Empty").ToArray();
        }
    }
}