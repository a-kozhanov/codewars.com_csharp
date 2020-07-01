/*
https://www.codewars.com/kata/5356ad2cbb858025d800111d/csharp

7 kyu
Name Array Capping

Create a method that accepts an array of names, and returns an array of each name with its first letter capitalized.

example

Kata.CapMe(new string[] {"jo", "nelson", "jurie"})     => new string[] {"Jo", "Nelson", "Jurie"}
Kata.CapMe(new string[] {"KARLY", "DANIEL", "KELSEY"}) => new string[] {"Karly", "Daniel", "Kelsey"}
*/

using System.Linq;

namespace CodeWars
{
    public class NameArrayCapping
    {
        public static string[] CapMe(string[] strings)
        {
            //return strings.Select(x => $"{char.ToUpper(x.First())}{x.Substring(1).ToLower()}").ToArray();
            //return strings.Select(n => char.ToUpper(n[0]) + n.Substring(1).ToLower()).ToArray();
            //return strings.Select(x => char.ToUpper(x[0]) + x.ToLower().Substring(1)).ToArray();
            //return strings.Select(s => $"{char.ToUpper(s[0])}{s[1..].ToLower()}").ToArray();
            //return strings.Select(x => $"{x[0]}".ToUpper() + x[1..].ToLower()).ToArray();
            return strings.Select(s => char.ToUpper(s[0]) + s[1..].ToLower()).ToArray();
        }
    }
}