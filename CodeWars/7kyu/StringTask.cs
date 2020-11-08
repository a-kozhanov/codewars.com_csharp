/*
https://www.codewars.com/kata/598ab63c7367483c890000f4/csharp

7 kyu
String Task

 Petya started to attend programming lessons. On the first lesson his task was to write a simple program. 
 The program was supposed to do the following: in the given string, consisting of uppercase and lowercase Latin letters, it:

deletes all the vowels,
inserts a character "." before each consonant,
replaces all uppercase consonants with corresponding lowercase ones.
 Vowels are letters "A", "O", "Y", "E", "U", "I", and the rest are consonants. 
 The program's input is exactly one string, it should return the output as a single string, 
 resulting after the program's processing the initial string.

Input:
 The first argument represents input string of Petya's program. 
 This string only consists of uppercase and lowercase Latin letters.

Output:
 Return the resulting string.

Examples:

('tour')      =>  '.t.r'
('Codewars')  =>  '.c.d.w.r.s'
('aBAcAba')   =>  '.b.c.b'
(c)Alexander
*/

using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class KataStringTask
    {
        public static string StringTask(string s)
        {
            //Regex.Replace(s.ToLower(), "(?i)(?:([aeiouy])|(.))",m => m.Groups[2].Success ? $".{m.Groups[2].Value.ToLowerInvariant()}" : string.Empty);
            //Regex.Replace(s, "(?i)(?:([aeiouy])|(.))", m => m.Groups[2].Success ? $".{m.Groups[2].Value.ToLowerInvariant()}" : string.Empty);
            //return s.Any() ? "." + string.Join(".", Regex.Replace(s.ToLower(), "[aeiouy]", "").ToCharArray()) : "";
            //return string.Concat(string.Concat(Regex.Split(s.ToLower(), "[aoyeui]")).Select(c => $".{c}"));
            //return string.Join("", s.ToLower().Where(x => !"aeiouy".Contains(x)).Select(x => "." + x));
            //return Regex.Replace(Regex.Replace(s, @"(?i)[aoyeui]", ""), @"(.)", @".$1").ToLower();

            //return Regex.Replace(s.ToLower(), "[aeiouy]", "").Aggregate("", (a, b) => $"{a}.{b}");
            //return Regex.Matches(s.ToLower(), "[^aeiouy]").Aggregate("", (a, b) => $"{a}.{b}");
            return Regex.Replace(Regex.Replace(s.ToLower(), "[aoyeui]", ""), "(.)", ".$1");
        }
    }
}