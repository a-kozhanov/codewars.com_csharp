/*
https://www.codewars.com/kata/535474308bb336c9980006f2/csharp

7 kyu
Greet Me

Write a method that takes one argument as name and then greets that name, 
capitalized and ends with an exclamation point.

Example:
Kata.Greet("riley") => "Hello Riley!"
Kata.Greet("JACK") => "Hello Jack!"
*/


using System.Globalization;

namespace CodeWars
{
    public class GreetMe
    {
        public static string Greet(string name)
        {
            //return "Hello " + char.ToUpper(name[0]) + name.Substring(1).ToLower() + "!";
            //return "Hello " + char.ToUpper(name[0]) + name.ToLower().Substring(1) + "!";
            //return "Hello " + (char) (name[0] - 32) + name.Substring(1, name.Length - 1) + "!";
            //return $"Hello {char.ToUpper(name[0])}{name.ToLower().Substring(1)}!";
            //return $"Hello {(char.ToUpper(name[0]) + name.Substring(1).ToLower())}!";
            //return $"Hello {char.ToUpper(name[0]) + name.Substring(1).ToLower()}!";
            //return $"Hello {char.ToUpper(name[0])}{name.Substring(1, name.Length - 1).ToLower()}!";
            //return $"Hello {name.Substring(0, 1).ToUpper()}{name.Substring(1).ToLower()}!";
            //return "Hello " + name.Remove(1, name.Length - 1).ToUpper() + name.Remove(0, 1).ToLower() + "!";
            //return $"Hello {CultureInfo.CurrentCulture.TextInfo.ToTitleCase(name.ToLower())}!";
            //return $"Hello {name.ToUpper()[0] + name.ToLower().Substring(1)}!";

            return $"Hello {name.ToUpper()[0] + name[1..].ToLower()}!";
            //return $"Hello {name[..1].ToUpper() + name[1..].ToLower()}!";


            //input.First().ToString().ToUpper() + input.Substring(1)
            //return s.Remove(1).ToUpper() + s.Substring(1);
            //char.ToUpper(s[0]) + s.Substring(1);
            //str.Replace(str[0], char.ToUpper(str[0]));
        }
    }
}