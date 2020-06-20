/*
https://www.codewars.com/kata/55955a48a4e9c1a77500005a/csharp

7 kyu
Say hello!

Say hello!

Write a function to greet a person. 
Function will take name as input and greet the person by saying hello. 
Return null/nil/None if input is empty string or null/nil/None.

Example:

greet("Niks") == "hello Niks!"
greet("") == null; // Return null if input is empty string
greet(null) == null; // Return null if input is null
*/

using System.Linq;

namespace CodeWars
{
    public class SayHello
    {
        public static string greet(string name)
        {
            //return name != null && name.Any() ? $"hello {name}!" : null;
            //return string.IsNullOrEmpty(name) ? null : $"hello {name}!";
            //return name == null | name == "" ? null : $"hello {name}!";
            return name?.Length > 0 ? $"hello {name}!" : null;
        }
    }
}