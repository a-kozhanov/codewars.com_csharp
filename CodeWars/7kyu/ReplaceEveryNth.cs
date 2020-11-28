/*
https://www.codewars.com/kata/57fcaed83206fb15fd00027a/csharp

7 kyu
Replace every nth

Task
Write a method, that replaces every nth char oldValue with char newValue.

Method:

ReplaceNth(string text, int n, char oldValue, char newValue)
Example:
n:         2
oldValue: 'a'
newValue: 'o'
"Vader said: No, I am your father!" -> "Vader soid: No, I am your fother!"
  1     2          3        4       -> 2nd and 4th occurence are replaced
Your method has to be case sensitive!

As you can see in the example: The first changed is the 2nd 'a'. So the start is always at the nth suitable char and not at the first!

If n is 0 or negative or if it is larger than the count of the oldValue, return the original text without a change.

The text and the chars will never be null.

Have fun coding it and please don't forget to vote and rank this kata! :-)

I have created other katas. Have a look if you like coding and challenges.
*/

using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class ReplaceEveryNth
    {
        public static string ReplaceNth(string text, int n, char oldValue, char newValue)
        {
            // int i = 0;
            // return text.Select(c => n > 0 && c == oldValue && ++i % n == 0 ? newValue : c)
            //     .Aggregate("", (s, c) => s + c);


            // int i = 1;
            // return n > 0
            //     ? text.Split(oldValue)
            //         .Aggregate((txt, word) => txt + (i++ % n == 0 ? newValue + word : oldValue + word))
            //     : text;


            // int i = 0;
            // return n > 0
            //     ? Regex.Replace(text, $"{oldValue}", m => ++i % n == 0 ? $"{newValue}" : m.Value)
            //     : text;


            // return n > 0
            //     ? string.Concat(text.Split(oldValue).Select((x, i) => i % n == 0 ? newValue + x : oldValue + x))
            //         .Substring(1)
            //     : text;


            int i = 0;
            return Regex.Replace(text, $"{oldValue}", m => n > 0 && ++i % n == 0 ? $"{newValue}" : m.Value);
        }
    }
}