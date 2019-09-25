using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

//https://www.codewars.com/kata/convert-a-string-to-an-array/train/csharp
//https://www.codewars.com/kata/57e76bc428d6fbc2d500036d/solutions/csharp

//Convert a string to an array

//Write a function to split a string and convert it into an array of words.For example:
//"Robin Singh" ==> ["Robin", "Singh"]
//"I love arrays they are my favorite" ==> ["I", "love", "arrays", "they", "are", "my", "favorite"]

namespace CodeWars
{
    public class ConvertStringToArray
    {
        public static string[] StringToArray(string str)
        {
            return str.Split();
        }
    }
}
