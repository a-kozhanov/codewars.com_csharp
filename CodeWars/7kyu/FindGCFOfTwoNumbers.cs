/*
https://www.codewars.com/kata/579e3476cf1fa55592000045/csharp

7 kyu
Find the GCF of Two Numbers

Your task here is the find the GCF (Greatest Common Factor) of any two numbers passed into a method, 
which will return one integer answer as an output.

Examples:
FindGCF(4, 6); // Should return 2
FindGCF(93, 186); // Should return 93
FindGCF(20, 5); // Should return 5
Here, inputs will always be natural numbers so there's no need to worry about negative values or zero.
*/

using System;

namespace CodeWars
{
    public class FindGCFOfTwoNumbers
    {
        public static int FindGCF(int num1, int num2)
        {
            // for (int i = num1 > num2 ? num1 : num2; i >= 1; i--)
            // {
            //     if (num1 % i == 0 && num2 % i == 0)
            //         return i;
            // }
            // return 0;


            //return num1 == 0 ? num2 : FindGCF(num2 % num1, num1);
            return num2 > 0 ? FindGCF(num2, num1 % num2) : num1;
        }
    }
}