/*
https://www.codewars.com/kata/59656c69253c365e58000046/csharp

7 kyu
maxPossibleScore

You're a teacher preparing a test for your students. Each question is worth some number of points. 
Some of the questions are new to the students, while others are questions they have already seen and practiced. 
Your scoring system doubles the value of new questions. Your job is to determine the maximum possible score.

Write a function doubleValue that accepts 1) an object of questions (as keys) and points (values) and 2) an array of new questions. 
The function should return the test's maximum possible score as an integer, where questions that are new are worth double points.

You can assume that all questions are unique.

Questions are case sensitive.

Example: maxPossibleScore({"a": 1, "b": 2, "c": 3}, ["a", "c"]); // 1 * 2 + 2 + 3 * 2 = 10
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class KataMaxPossibleScore
    {
        public static int MaxPossibleScore(Dictionary<object, int> obj, object[] arr)
        {
            //return obj.Select(x => Array.IndexOf(arr, x.Key) >= 0 ? x.Value * 2 : x.Value).Sum();
            //return obj.Sum(i => arr.Contains(i.Key) ? i.Value * 2 : i.Value);//.Sum();
            //return obj.Select(x => arr.Contains(x.Key) ? x.Value * 2 : x.Value).Sum();
            //return obj.Sum(x => arr.Contains(x.Key) ? x.Value * 2 : x.Value);
            //return obj.Keys.Sum(q => (arr.Contains(q) ? 2 : 1) * obj[q]);
            return obj.Sum(v => v.Value * (arr.Contains(v.Key) ? 2 : 1));
        }
    }
}