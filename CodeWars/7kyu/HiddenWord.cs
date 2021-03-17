/*
https://www.codewars.com/kata/5906a218dfeb0dbb52000005/csharp

7 kyu
The Hidden Word

Maya writes weekly articles to a well known magazine, 
but she is missing one word each time she is about to send the article to the editor. 
The article is not complete without this word. 
Maya has a friend, Dan, and he is very good with words, but he doesn't like to just give them away. 
He texts Maya a number and she needs to find out the hidden word. 
The words can contain only the letter: "a", "b", "d", "e", "i", "l", "m", "n", "o", and "t".

Luckily, Maya has the key:

"a" - 6 "b" - 1 "d" - 7 "e" - 4 "i" - 3 "l" - 2 "m" - 9 "n" - 8 "o" - 0 "t" - 5

You can help Maya by writing a function that will take a number between 100 and 999999 and return a string with the word.

The input is always a number, contains only the numbers in the key. The output should be always a string with one word, all lowercase.

Maya won't forget to thank you at the end of her article :)
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class HiddenWord
    {
        public string hidden(int num)
        {
            return string.Concat($"{num}".Select(c => "oblietadnm"[c - '0']));
            //return string.Concat($"{num}".Select(c => "oblietadnm"[c - 48]));

            //return string.Concat(num.ToString().Select(x => "oblietadnm"[x - '0']));
            //return string.Concat(num.ToString().Select(x => "oblietadnm"[int.Parse(x.ToString())]));

            //return new string(num.ToString().Select(n => "oblietadnm"[int.Parse(n.ToString())]).ToArray());


            // Dictionary<int, char> d = new Dictionary<int, char>
            // {
            //     {0, 'o'}, {1, 'b'}, {2, 'l'}, {3, 'i'}, {4, 'e'},
            //     {5, 't'}, {6, 'a'}, {7, 'd'}, {8, 'n'}, {9, 'm'}
            // };
            // return string.Concat(num.ToString().Select(x => d[int.Parse(x.ToString())]));

            //return string.Concat(num.ToString().Select(x => d[(int) char.GetNumericValue(x)]));


            // return num.ToString().Replace("6", "a").Replace("1", "b").Replace("7", "d").Replace("4", "e")
            //     .Replace("3", "i").Replace("2", "l").Replace("9", "m").Replace("8", "n").Replace("5", "t")
            //     .Replace("0", "o");


            // var d = new Dictionary<char, char>
            // {
            //     {'0', 'o'}, {'1', 'b'}, {'2', 'l'}, {'3', 'i'}, {'4', 'e'},
            //     {'5', 't'}, {'6', 'a'}, {'7', 'd'}, {'8', 'n'}, {'9', 'm'}
            // };
            // return string.Concat((num.ToString()).Select(x => d[x]).ToArray());


            // var letters = new[] {"o", "b", "l", "i", "e", "t", "a", "d", "n", "m"};
            // return num.ToString().Aggregate("", (current, s) => current + letters[int.Parse(s.ToString())]);
        }
    }
}