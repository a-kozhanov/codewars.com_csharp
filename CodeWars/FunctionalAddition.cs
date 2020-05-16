/*
https://www.codewars.com/kata/538835ae443aae6e03000547/csharp

7 kyu
Functional Addition

Create a function add(n)/Add(n) which returns a function that always adds n to any number

Note for Java: the return type and methods have not been provided to make it a bit more challenging.

Func<double, double> AddOne = Kata.Add(1);
AddOne(3) => 4
*/

using System;

namespace CodeWars
{
    public class FunctionalAddition
    {
        public static Func<double, double> Add(double n)
        {
            return x => x + n;
        }
    }
}