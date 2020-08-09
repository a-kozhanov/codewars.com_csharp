/*
https://www.codewars.com/kata/5839edaa6754d6fec10000a2/csharp

6 kyu
Find the missing letter

Write a method that takes an array of consecutive (increasing) letters as input and that returns the missing letter in the array.

You will always get an valid array. And it will be always exactly one letter be missing. 
The length of the array will always be at least 2.
The array will always contain letters in only one case.

Example:
['a','b','c','d','f'] -> 'e' 
['O','Q','R','S'] -> 'P'
["a","b","c","d","f"] -> "e"
["O","Q","R","S"] -> "P"

(Use the English alphabet with 26 letters!)
Have fun coding it and please don't forget to vote and rank this kata! :-)
I have also created other katas. Take a look if you enjoyed this kata!
*/

using System.Linq;

namespace CodeWars
{
    public class KataFindMissingLetter
    {
        public static char FindMissingLetter(char[] array)
        {
            //return Enumerable.Range(array[0], array.Length).Select(x => (char) x).Except(array).First();
            //return (char) Enumerable.Range(array[0], array.Length).First(x => !array.Contains((char) x));
            return (char) (array.Where((c, i) => array[i + 1] - c != 1).First() + 1);
        }
    }
}