/*
https://www.codewars.com/kata/5299413901337c637e000004

7 kyu
Return the Missing Element

Fellow code warrior, we need your help! We seem to have lost one of our array elements, 
and we need your help to retrieve it! Our array, superImportantArray, 
was supposed to contain all of the integers from 0 to 9 (in no particular order), but one of them seems to be missing.

Write a function called getMissingElement that accepts an array of unique integers between 0 and 9 (inclusive), 
and returns the missing element.

Examples:
Kata.GetMissingElement( [0, 5, 1, 3, 2, 9, 7, 6, 4] ); // returns 8
Kata.GetMissingElement( [9, 2, 4, 5, 7, 0, 8, 6, 1] ); // returns 3
*/

using System.Linq;

namespace CodeWars
{
    public class ReturnMissingElement
    {
        public static int GetMissingElement(int[] superImportantArray)
        {
            //return new[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10}.Except(superImportantArray).First();
            return Enumerable.Range(0, 10).First(i => !superImportantArray.Contains(i));
            //return Enumerable.Range(0, 10).Except(superImportantArray).First();
            //return 45 - superImportantArray.Sum();
        }
    }
}