using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//https://www.codewars.com/kata/reversed-strings/train/csharp
//https://www.codewars.com/kata/reversed-strings/solutions/csharp
//Complete the solution so that it reverses the string value passed into it.
//Kata.Solution("world") //returns "dlrow"


namespace CodeWars
{
    public static class ReversedStrings
    {
        public static string Solution(string str)
        {
            return new string(str.Reverse().ToArray());
        }
    }
}
