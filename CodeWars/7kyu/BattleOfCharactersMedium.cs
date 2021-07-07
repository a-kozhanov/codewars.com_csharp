/*
https://www.codewars.com/kata/595e9f258b763bc2d2000032/csharp

7 kyu
Battle of the characters (Medium)

Description:
Groups of characters decided to make a battle. Help them to figure out what group is more powerful. 
Create a function that will accept 2 variables and return the one who's stronger.

Rules:
Each character has its own power:
  A = 1, B = 2, ... Y = 25, Z = 26
  a = 0.5, b = 1, ... y = 12.5, z = 13
Only alphabetical characters can and will participate in a battle.
Only two groups to a fight.
Group whose total power (a + B + c + ...) is bigger wins.
If the powers are equal, it's a tie.
Examples:
  battle("One", "Two"); // => "Two"`
  battle("ONE", "NEO"); // => "Tie!"
Related kata:
Battle of the characters (Easy)
*/

using System.Linq;

namespace CodeWars
{
    public class BattleOfCharactersMedium
    {
        public static string Battle(string x, string y)
        {
            double Score(string s) => s.Sum(c => char.IsLower(c) ? (c - 96) / 2d : c - 64);
            double scoreX = Score(x);
            double scoreY = Score(y);
            return scoreX == scoreY ? "Tie!" : scoreX > scoreY ? x : y;
        }
    }
}