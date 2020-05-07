/*
https://www.codewars.com/kata/595519279be6c575b5000016/train/csharp

7 kyu
Battle of the characters (Easy)

Description:
Groups of characters decided to make a battle. Help them to figure out which group is more powerful. 
Create a function that will accept 2 variables and return the one who's stronger.

Rules:
Each character have its own power: A = 1, B = 2, ... Y = 25, Z = 26
Only capital chatacters can and will participate a battle.
Only two groups to a fight.
Group whose total power (A + B + C + ...) is bigger wins.
If the powers are equal, it's a tie.

Examples:
  battle("ONE", "TWO"); // => "TWO"`
  battle("ONE", "NEO"); // => "Tie!"
  
Related kata:
Battle of the characters (Medium)
*/

using System.Linq;

namespace CodeWars
{
    public class BattleOfCharactersEasy
    {
        public static string Battle(string x, string y)
        {
            // var xSum = x.Sum(c => c - 65);
            // var ySum = y.Sum(c => c - 65);
            // return xSum == ySum ? "Tie!" : xSum > ySum ? x : y;

            return new[] {y, "Tie!", x}[x.Sum(c => c - 64).CompareTo(y.Sum(c => c - 64)) + 1];
        }
    }
}