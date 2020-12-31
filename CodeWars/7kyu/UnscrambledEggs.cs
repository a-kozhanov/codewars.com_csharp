/*
https://www.codewars.com/kata/55ea5650fe9247a2ea0000a7/csharp

7 kyu
Unscrambled eggs

The string given to your function has had an "egg" inserted directly after each consonant. 
You need to return the string before it became eggcoded.

Example
unscrambleEggs("Beggegeggineggneggeregg"); => "Beginner"
//             "B---eg---in---n---er---"

Kata is supposed to be for beginners to practice regular expressions, so commenting would be appreciated.
*/

namespace CodeWars
{
    public class UnscrambledEggs
    {
        public static string UnscrambleEggs(string word)
        {
            return word.Replace("egg", "");
        }
    }
}