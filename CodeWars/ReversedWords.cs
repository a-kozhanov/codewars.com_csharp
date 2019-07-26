using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

//https://www.codewars.com/kata/reversed-words/train/csharp
//https://www.codewars.com/kata/51c8991dee245d7ddf00000e/solutions/csharp

//Reversed Words

//Complete the solution so that it reverses all of the words within the string passed in.
//Example:
//Kata.ReverseWords("The greatest victory is that which requires no battle");
//// should return "battle no requires which that is victory greatest The"

namespace CodeWars
{
    public class KataReversedWords
    {
        public static string ReverseWords(string str)
        {
            return string.Join(" ", str.Split().Reverse());
        }
    }
}
