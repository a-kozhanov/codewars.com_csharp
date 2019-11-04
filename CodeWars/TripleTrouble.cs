/*
https://www.codewars.com/kata/triple-trouble-2/train/csharp
https://www.codewars.com/kata/5704aea738428f4d30000914/solutions/csharp

8 kyu
Triple Trouble

Create a function that will return a string that combines all of the letters of the three inputed strings in groups. Taking the first letter of all of the inputs and grouping them next to each other. Do this for every letter, see example below!

Ex) Input: "aa", "bb" , "cc" => Output: "abcabc"

Note: You can expect all of the inputs to be the same length.

*/

using System;
using System.Linq;

namespace CodeWars
{
    public class KataTripleTrouble8
    {
        public static string TripleTrouble(string one, string two, string three)
        {
            var result = "";
            for (var i = 0; i < one.Length; i++)
            {
                result += $"{one[i]}{two[i]}{three[i]}";
            }
            return result;
        }


        //public static string TripleTrouble(string one, string two, string three) => string.Concat(Enumerable.Range(0, one.Length).Select(x => $"{one[x]}{two[x]}{three[x]}"));


        //public static string TripleTrouble(string one, string two, string three)
        //{
        //    return string.Concat(one.Select((x,i) => x.ToString() + two[i] + three[i])); 
        //}


        //public static string TripleTrouble(string one, string two, string three)
        //{
        //    return Enumerable.Range(0,one.Length).Aggregate("",(a,b) => $"{a}{one[b]}{two[b]}{three[b]}");
        //}


        //public static string TripleTrouble(string one, string two, string three)
        //{
        //    return string.Concat(one.Zip(two.Zip(three, (b, c) => "" + b + c), (a, b) => a + b));
        //}

        //public static string TripleTrouble(string one, string two, string three)
        //{
        //    string output = string.Concat(one.Select((x, i) => x.ToString() + two[i] + three[i]));

        //    return output;
        //}


        //public static string TripleTrouble(string one, string two, string three)
        //{
        //    return Enumerable.Range(0, one.Length)
        //        .Aggregate("", (ac, cur) => $"{ac}{one[cur]}{two[cur]}{three[cur]}");
        //}



    }
}