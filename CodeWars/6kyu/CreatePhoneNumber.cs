/*
https://www.codewars.com/kata/525f50e3b73515a6db000b83/train/csharp
https://www.codewars.com/kata/525f50e3b73515a6db000b83/solutions/csharp

6 kyu
Create Phone Number

Write a function that accepts an array of 10 integers (between 0 and 9), 
that returns a string of those numbers in the form of a phone number.

Example:
Kata.CreatePhoneNumber(new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 0}) // => returns "(123) 456-7890"
The returned format must be correct in order to complete this challenge.
Don't forget the space after the closing parentheses!
*/

using System;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class KataCreatePhoneNumber
    {
        public static string CreatePhoneNumber(int[] n)
        {
            //return $"({n[0]}{n[1]}{n[2]}) {n[3]}{n[4]}{n[5]}-{n[6]}{n[7]}{n[8]}{n[9]}";
            return $"{int.Parse(string.Concat(n)):(000) 000-0000}";
        }

        // public static string CreatePhoneNumber(int[] numbers)
        // {
        //     return long.Parse(string.Concat(numbers)).ToString("(000) 000-0000");
        // }

        // public static string CreatePhoneNumber(int[] n) //KISS principle
        // {
        //     return "(" + n[0] + n[1] + n[2] + ") " + n[3] + n[4] + n[5] + "-" + n[6] + n[7] + n[8] + n[9];
        // }

        // public static string CreatePhoneNumber(int[] numbers) => new Regex("(...)(...)(....)").Replace(String.Concat(numbers), "($1) $2-$3");

        // public static string CreatePhoneNumber(int[] numbers)
        // {
        //     return string.Format("({0}{1}{2}) {3}{4}{5}-{6}{7}{8}{9}",numbers.Select(x=>x.ToString()).ToArray());
        // }

        // public static string CreatePhoneNumber(int[] n) => 
        //     $"({n[0]}{n[1]}{n[2]}) {n[3]}{n[4]}{n[5]}-{n[6]}{n[7]}{n[8]}{n[9]}";


        // public static string CreatePhoneNumber(int[] numbers)
        // {
        //     return string.Format("({0}{1}{2}) {3}{4}{5}-{6}{7}{8}{9}", numbers[0], numbers[1], numbers[2], numbers[3], numbers[4], numbers[5], numbers[6], numbers[7], numbers[8], numbers[9]);   
        // }  


        // public static string CreatePhoneNumber(int[] numbers)
        // {
        //     return String.Format("{0:(000) 000-0000}", ulong.Parse(String.Join("", numbers)));
        // }


        // public static string CreatePhoneNumber(int[] numbers) 
        //     => String.Format("({0}) {1}-{2}",
        //         numbers.Take(3).Select(n => n.ToString()).Aggregate((a, b) => a + b),
        //         numbers.Skip(3).Take(3).Select(n => n.ToString()).Aggregate((a, b) => a + b),
        //         numbers.Skip(6).Take(4).Select(n => n.ToString()).Aggregate((a, b) => a + b)); 

        // public class Kata
        // {
        //     private const string PhoneNumberFormat = @"({0}{1}{2}) {3}{4}{5}-{6}{7}{8}{9}";
        //
        //     public static string CreatePhoneNumber(int[] numbers)
        //     {
        //         if(numbers.Length > 10)
        //         {
        //             throw new ArgumentException("More than ten numbers contained in the array");
        //         }
        //
        //         return string.Format(PhoneNumberFormat, numbers.Select(x => x.ToString()).ToArray());
        //     }
        // }


        // public static string CreatePhoneNumber(int[] n)
        // {
        //     return "("+n[0]+n[1]+n[2]+") "+n[3]+n[4]+n[5]+"-"+n[6]+n[7]+n[8]+n[9];
        // }


        // public static string CreatePhoneNumber(int[] numbers)
        // {
        //     return string.Join("",numbers).Insert(6,"-").Insert(3,") ").Insert(0,"(");
        // }

        // public static string CreatePhoneNumber(int[] numbers)
        // {
        //
        //     return String.Format("({0}{1}{2}) {3}{4}{5}-{6}{7}{8}{9}", numbers.Select(x=>(object)x).ToArray());
        // }

        // public static string CreatePhoneNumber(int[] numbers)
        // {
        //     string result = string.Join("",numbers);
        //     return Regex.Replace(result,@"(\d{3})(\d{3})(\d{4})", "($1) $2-$3");
        // }
    }
}