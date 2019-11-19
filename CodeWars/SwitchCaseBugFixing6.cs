
/*
https://www.codewars.com/kata/switch-slash-case-bug-fixing-number-6/train/csharp
https://www.codewars.com/kata/55c933c115a8c426ac000082/solutions/csharp

8 kyu
Switch/Case - Bug Fixing #6

Oh no! Timmy's evalObject function doesn't work. He uses Switch/Cases to evaluate the given properties of an object, can you fix timmy's function?
*/


using System;

namespace CodeWars
{
    public class SwitchCaseBugFixing6
    {
        public static double EvalObject(double value1, double value2, char operation)
        {
            switch (operation)
            {
                case '+': return value1 + value2;
                case '-': return value1 - value2;
                case '/': return value1 / value2;
                case '*': return value1 * value2;
                case '%': return value1 % value2;
                case '^': return Math.Pow(value1, value2);
                default: return 0;
            }
        }
    }
}