/*
https://www.codewars.com/kata/exclusive-or-xor-logical-operator/train/csharp
https://www.codewars.com/kata/56fa3c5ce4d45d2a52001b3c/solutions/csharp

8 kyu
Exclusive "or" (xor) Logical Operator

Overview
In some scripting languages like PHP, there exists a logical operator (e.g. &&, ||, and, or, etc.) called the "Exclusive Or" (hence the name of this Kata). 
The exclusive or evaluates two booleans. 
It then returns true if exactly one of the two expressions are true, false otherwise. 

For example:
false xor false == false // since both are false
true xor false == true // exactly one of the two expressions are true
false xor true == true // exactly one of the two expressions are true
true xor true == false // Both are true.  "xor" only returns true if EXACTLY one of the two expressions evaluate to true.

Task
Since we cannot define keywords in Javascript (well, at least I don't know how to do it), 
your task is to define a function xor(a, b) where a and b are the two expressions to be evaluated. 
Your xor function should have the behaviour described above, 
returning true if exactly one of the two expressions evaluate to true, false otherwise.
*/

namespace CodeWars
{
    public class ExclusiveOrXorLogicalOperator
    {
        public static bool Xor(bool a, bool b)
        {
            return a ^ b;
        }

        //public static bool Xor(bool a, bool b) => a != b;

        //public static bool Xor(bool a, bool b) => a ^ b;


        //public static bool Xor(bool a, bool b)
        //{
        //    return a == true && b == true ? false : a == true || b == true ? true : false;
        //}


        //public static bool Xor(bool a, bool b)
        //{
        //    return a == b ? false : true;
        //}

        //public static bool Xor(bool a, bool b)
        //{
        //    return (a != b && (a || b));
        //}

    }
}