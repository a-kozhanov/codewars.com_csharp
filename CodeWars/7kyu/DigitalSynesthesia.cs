/*
https://www.codewars.com/kata/56047bb6bcd785ce75000069/csharp

7 kyu
Digital Synesthesia

Setup
Sysnesthesia is a nuerological phenomenon where a person may experience a sensory impulse as if it had been from a different sense. 
For example, hearing music as if seeing a series of colors.

Today we will be creating a function to mimic a synesthetic experience. 
The function will receive a string representing music, and return an array of strings representing colors.

To represent music as a string, we will be using the ABC music notation. This notation is a whole language, 
but all you need to know for this kata is that it is comprised of all ASCII characters. In it's simplest usage, 
"ABCEFG" is an ascending scale.

To represent color as a string, we will use standard CSS hex notation, e.g. #FFFFFF for white. 
Letters are upper case.

Task
Starting from the begining of the input string, for every three ASCII characters, include the associated color in the returned array. 
If the input string is not evenly divisible by three, ignore any trailing characters. Empty and null input should return an empty array.

I define a color as being associated with three ASCII characters when each pair of hexidecimal digits in the color match the hexidecimal ASCII values of the respective characters. 
For example, #414243 is associated with the notes ABC.
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class DigitalSynesthesia
    {
        public static string[] MusicToColor(string music)
        {
            return music == null
                ? new string[0]
                : Enumerable.Range(0, music.Length / 3)
                    .Select(i => music.Skip(i * 3).Take(3))
                    .Select(x => "#" + string.Concat(x.Select(c => $"{(int) c:X}"))).ToArray();


            // return music == null
            //     ? new string[0]
            //     : Enumerable.Range(0, music.Length / 3)
            //         .Select(i => $"#{string.Concat(music.Substring(i * 3, 3).Select(c => ((int) c).ToString("X2")))}")
            //         .ToArray();


            // return Enumerable.Range(0, music.Length / 3)
            //     .Select(i => $"#{string.Concat(music.Substring(i * 3, 3).Select(c => ((int) c).ToString("X2")))}")
            //     .ToArray();


            // return music == null
            //     ? new string[0]
            //     : Enumerable.Range(0, music.Length / 3)
            //         .Select(i => music.Skip(i * 3).Take(3))
            //         .Select(t => "#" + string.Concat(t.Select(c => $"{(int) c:X}"))).ToArray();


            // return (music == null)
            //     ? new string[0]
            //     : Enumerable.Range(0, music.Length / 3).Select(i => "#" + Convert.ToString(music[3 * i], 16).ToUpper() +
            //                                                         Convert.ToString(music[3 * i + 1], 16).ToUpper() +
            //                                                         Convert.ToString(music[3 * i + 2], 16).ToUpper())
            //         .ToArray();
        }
    }
}