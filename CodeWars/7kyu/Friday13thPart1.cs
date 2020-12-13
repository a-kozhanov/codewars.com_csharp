/*
https://www.codewars.com/kata/5925acf31a9825d616000e74/train/csharp

7 kyu
Friday the 13th Part 1

It's Friday the 13th, and Jason is ready for his first killing spree!

Create a function, killcount, that accepts two arguments: an array of array pairs (the conselor's name and intelligence - ["Chad", 2]) and an integer representing Jason's intellegence.

Ruby, Python, Crystal:

counselors = [["Chad", 2], ["Tommy", 9]]
jason = 7
JavaScript:

var counselors = [["Chad", 2], ["Tommy", 9]];
var jason = 7;
PHP:

$counselors = [["Chad", 2], ["Tommy", 9]];
$jason = 7;
Your function must return an array of the names of all the counselors who can be outsmarted and killed by Jason.

alt text

Happy Friday the 13th!
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class Friday13thPart1
    {
        public static string[] KillCount(Dictionary<string, int> counselors, int jason)
        {
            return counselors.Where(k => k.Value < jason).Select(k => k.Key).ToArray();
        }
    }
}