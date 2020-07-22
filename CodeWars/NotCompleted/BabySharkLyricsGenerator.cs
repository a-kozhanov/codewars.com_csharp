/*
https://www.codewars.com/kata/5d076515e102162ac0dc514e/csharp

7 kyu
Baby shark lyrics generator

Baby Shark Lyrics
Create a function, as short as possible, that returns this lyrics.
Your code should be less than 300 characters. Watch out for the three points at the end of the song.

Baby shark, doo doo doo doo doo doo
Baby shark, doo doo doo doo doo doo
Baby shark, doo doo doo doo doo doo
Baby shark!
Mommy shark, doo doo doo doo doo doo
Mommy shark, doo doo doo doo doo doo
Mommy shark, doo doo doo doo doo doo
Mommy shark!
Daddy shark, doo doo doo doo doo doo
Daddy shark, doo doo doo doo doo doo
Daddy shark, doo doo doo doo doo doo
Daddy shark!
Grandma shark, doo doo doo doo doo doo
Grandma shark, doo doo doo doo doo doo
Grandma shark, doo doo doo doo doo doo
Grandma shark!
Grandpa shark, doo doo doo doo doo doo
Grandpa shark, doo doo doo doo doo doo
Grandpa shark, doo doo doo doo doo doo
Grandpa shark!
Let's go hunt, doo doo doo doo doo doo
Let's go hunt, doo doo doo doo doo doo
Let's go hunt, doo doo doo doo doo doo
Let's go hunt!
Run away,…
Good Luck!
*/

using System.Linq;


namespace CodeWars
{
    public class BabySharkLyricsGenerator
    {
        //public static string BabySharkLyrics()=>string.Concat(new[]{"Baby","Mommy","Daddy","Grandma","Grandpa"}.Select(s=>s+" shark").Append("Let's go hunt").Select(x=>string.Join(", doo doo doo doo doo doo\n",Enumerable.Repeat(x,4))+"!\n"))+"Run away,…\n";
        
        public static string BabySharkLyrics() => string.Concat(new[] {"Baby", "Mommy", "Daddy", "Grandma", "Grandpa"}
            .Select(s => s + " shark").Append("Let's go hunt").Select(x =>
                string.Join(", doo doo doo doo doo doo\n",
                    Enumerable.Repeat(x, 4)) + "!\n")) + "Run away,…\n";
    }
}