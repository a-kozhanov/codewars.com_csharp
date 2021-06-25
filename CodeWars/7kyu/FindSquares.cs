/*
https://www.codewars.com/kata/60908bc1d5811f0025474291/csharp

7 kyu
Find the Squares

Problem
You are to write a function that takes an odd integer which is the difference between two consecutive perfect squares and find the squares

Input Format
num : Odd Integer 0<n<1000000

Output Format
Answer: String containing the bigger and smaller squares in one line like "Max-Min"

Examples
findSquares(9)  //returns '25-16'
findSquares(5)  // returns '9-4' 
*/

using System;

namespace CodeWars
{
    public class FindSquares
    {
        public static string findSquares(int n)
        {
            long a = (n + 1) / 2;
            long b = a - 1;
            return $"{a * a}-{b * b}";

            // return $"{Math.Pow((n + 1) / 2, 2)}-{Math.Pow((n - 1) / 2, 2)}";
        }
    }
}