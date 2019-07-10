
//https://www.codewars.com/kata/parse-nice-int-from-char-problem/train/csharp
//https://www.codewars.com/kata/557cd6882bfa3c8a9f0000c1/solutions/csharp

//Parse nice int from char problem

//Ask a small girl - "How old are you?". She always says strange things... Lets help her!
//For correct answer program should return int from 0 to 9.
//Assume test input string always valid and may look like "1 year old" or "5 years old", etc.. The first char is number only.


using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class ParseNiceIntFromChar
    {
        public static int GetAge(string inputString)
        {
            return int.Parse(string.Concat(inputString.Where(char.IsDigit)));
        }


        //public static int GetAge(string inputString)
        //{
        //    return (int)char.GetNumericValue(inputString[0]);
        //}

        //public static int GetAge(string input) => int.Parse(input.Split()[0]);


        //public static int GetAge(string inputString)
        //{
        //    return Int32.Parse(Regex.Match(inputString, @"\d+").Value);
        //}

        //public static int GetAge(string inputString)
        //{
        //    var result = Int32.Parse(inputString.Substring(0,1));
        //    return result;
        //}

        //public static int GetAge(string inputString) => inputString[0] - '0';

        //public static int GetAge(string age)
        //{
        //    return age[0] - '0';
        //}

        //public static int GetAge(string inputString)
        //{
        //    return Convert.ToInt32(inputString[0] -'0');
        //}

        //public static int GetAge(string inputString)
        //{
        //    return Convert.ToInt32(inputString.First().ToString());
        //}

        //public static int GetAge(string inputString)
        //{
        //    int val = int.Parse(inputString.Split(' ')[0]);
        //    return val;
        //}

        //public static int GetAge(string inputString) => (int)char.GetNumericValue(inputString.First(c => char.IsDigit(c)));




    }
}