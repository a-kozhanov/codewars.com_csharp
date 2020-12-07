/*
https://www.codewars.com/kata/5b94d7eb1d5ed297680000ca/solutions/csharp

7 kyu
Simple directions reversal

In this Kata, you will be given directions and your task will be to find your way back.

solve(["Begin on Road A","Right on Road B","Right on Road C","Left on Road D"]) = ['Begin on Road D', 'Right on Road C', 'Left on Road B', 'Left on Road A']
solve(['Begin on Lua Pkwy', 'Right on Sixth Alley', 'Right on 1st Cr']) =  ['Begin on 1st Cr', 'Left on Sixth Alley', 'Left on Lua Pkwy']
More examples in test cases.

Good luck!

Please also try Simple remove duplicates
*/


using System.Linq;

namespace CodeWars
{
    public class SimpleDirectionsReversal
    {
        public static string[] solve(string[] arr)
        {
            var dirs = arr.Reverse().Select(x => x.StartsWith("Right") ? "Left" : x.StartsWith("Left") ? "Right" : "")
                .ToArray();
            return arr.Reverse().Select((x, i) => (i == 0 ? "Begin" : dirs[i - 1]) + x[x.IndexOf(' ')..]).ToArray();
        }
    }
}