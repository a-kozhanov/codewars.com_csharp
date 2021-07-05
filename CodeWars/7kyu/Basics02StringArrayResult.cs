/*
https://www.codewars.com/kata/56b5dc05e3a3a7691c000c1e/csharp

7 kyu
Basics 02: String - Array - Result?

Your task is to calculate some different things on a given string. So this kata checks some basics, it's not too difficult.

So what to do?

Input: String which consists of integers and chars separated by ";"

1. Recognize and sum all numbers
2. Calculate average and round it to int
3. Calculate sum of the digits from result of 2.
4. Check if this result is divisible by 5
Return your results as a string containing points 2.,3. and 4., i.e. "2.,3.,4." (comma separated string with single results, see example)

Easy example:

Input: "-500;500;1500;-;+++;;;ABC"
Output: "500,5,TRUE"

Why?
2.=> -500+500+1500=1500 / 3 = 500
3.=> 5+0+0=5
4.=> 5/5=1 => divisible => TRUE (not => FALSE)
i.e. Output= "500,5,TRUE"
First there are some static tests, later on random tests too...


Hope you have fun:-)!
*/

using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class Basics02StringArrayResult
    {
        public string calculateArray(string stringArray)
        {
            var avg = (int) stringArray.Split(';').Where(x => int.TryParse(x, out _)).Average(x => int.Parse(x) + 0.5);
            var sum = $"{avg}".Sum(x => x - 48);
            return $"{avg},{sum},{sum % 5 == 0}".ToUpper();


            // var avg = (int) Math.Round(stringArray.Split(';').Where(x => int.TryParse(x, out _)).Average(int.Parse));
            // var avg = (int) stringArray.Split(';').Where(x => int.TryParse(x, out _)).Average(x => int.Parse(x) + 0.5);
            // // var sum = $"{avg}".Sum(x => int.Parse(x.ToString()));
            // var sum = $"{avg}".Sum(x => x - 48);
            // // var r3 = sum % 5 == 0 ? "TRUE" : "FALSE";
            // string result = $"{avg},{sum},{sum % 5 == 0}".ToUpper();
            // // string result = $"{avg},{sum},{(sum % 5 == 0 ? "TRUE" : "FALSE")}";
            // return result;


            // int average = (int) (stringArray.Split(';').Where(x => Regex.IsMatch(x, @"^-?\d+$"))
            //     .Average(Convert.ToInt32) + 0.5);
            // int digitSum = average.ToString().Sum(x => x - '0');
            // return $"{average},{digitSum},{(digitSum % 5 == 0 ? "TRUE" : "FALSE")}";


            // var r1 = stringArray.Split(';').Where(x => int.TryParse(x, out _)).Sum(x => int.Parse(x));
            // var avg = (int) Math.Round(stringArray.Split(';').Where(x => int.TryParse(x, out _)).Average(int.Parse));
            // var sum = avg.ToString().Select(x => int.Parse(x.ToString())).Sum();
            // var r3 = sum % 5 == 0;
            // string result = $"{avg},{sum},{r3}".ToUpper();
            // return result;
        }
    }
}