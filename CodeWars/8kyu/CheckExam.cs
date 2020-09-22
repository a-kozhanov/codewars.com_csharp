/*
https://www.codewars.com/kata/5a3dd29055519e23ec000074/

8 kyu
Check the exam

The first input array is the key to the correct answers to an exam, like ["a", "a", "b", "d"]. 
The second one contains a student's submitted answers.

The two arrays are not empty and are the same length. Return the score for this array of answers, 
giving +4 for each correct answer, -1 for each incorrect answer, and +0 for each blank answer, 
represented as an empty string (in C the space character is used).

If the score < 0, return 0.

For example:

checkExam(["a", "a", "b", "b"], ["a", "c", "b", "d"]) → 6
checkExam(["a", "a", "c", "b"], ["a", "a", "b",  ""]) → 7
checkExam(["a", "a", "b", "c"], ["a", "a", "b", "c"]) → 16
checkExam(["b", "c", "b", "a"], ["",  "a", "a", "c"]) → 0
*/

using System;
using System.Linq;

namespace CodeWars
{
    public static class KataCheckExam
    {
        public static int CheckExam(string[] arr1, string[] arr2)
        {
            int sum = 0;
            for (var i = 0; i < arr2.Length; i++)
            {
                if (arr1[i] == arr2[i])
                    sum += 4;
                else if (arr2[i] == "")
                    sum += 0;
                else
                    sum += -1;
            }

            return sum > 0 ? sum : 0;


            //return Math.Max(arr2.Select((c, i) => c == "" ? 0 : c == arr1[i] ? 4 : -1).Sum(), 0);
        }
    }
}