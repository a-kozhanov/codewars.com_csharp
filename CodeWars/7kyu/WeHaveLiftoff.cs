/*
https://www.codewars.com/kata/53d6387b83db278202000802/csharp

7 kyu
We Have Liftoff

You have an array of numbers 1 through n (where 1 <= n <= 10). 
The array needs to be formatted correctly for the person reading the countdown of a spaceship launch.

Unfortunately, the person reading the countdown only knows how to read strings. 
After the array is sorted correctly make sure it's in a format he can understand.

Between each number should be a space and after the final number (n) should be the word 'liftoff!'

Example:
Kata.Liftoff(new List<int> {2, 8, 10, 9, 1, 3, 4, 7, 6, 5}) => "10 9 8 7 6 5 4 3 2 1 liftoff!"
*/

using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class WeHaveLiftoff
    {
        public static string Liftoff(List<int> instructions)
        {
            return $"{string.Join(" ", instructions.OrderBy(x => -x))} liftoff!";
            //return string.Join(" ", instructions.OrderByDescending(i => i)) + " liftoff!";
        }
    }
}