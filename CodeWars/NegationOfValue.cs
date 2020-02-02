/*
https://www.codewars.com/kata/58f6f87a55d759439b000073/train/csharp
https://www.codewars.com/kata/58f6f87a55d759439b000073/solutions/csharp

7 kyu
Negation of a Value

In programming you know the use of the logical negation operator (!), it reverses the meaning of a condition.

!false = true
!!false = false
Your task is to complete the function 'negationValue()' that takes a string of negations with a value and returns what the value would be if those negations were applied to it.

negationValue("!", false); //=> true
negationValue("!!!!!", true); //=> false
negationValue("!!", []); //=> true
Do not use the eval() function or the Function() constructor in JavaScript.

Note: Always return a boolean value, even if there're no negations.
*/

using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class KataNegationOfValue
    {
        public static bool NegationValue(string str, bool value)
        {
            // for (var i = 0; i < str.Length; i++)
            // {
            //     value = !value;
            // }
            //
            // return value;

            return value == (str.Length % 2 == 0);
        }

        // public static bool NegationValue(string s, bool val) => s.Aggregate(val, (r,_) => !r);


        // public static bool NegationValue(string str, bool value)
        // {
        //     if (!str.All(c => c == '!')) 
        //     {
        //         throw new ArgumentException("Expected a string input of only !s");
        //     }
        //
        //     return value == ((str.Length & 1) == 0);
        // }

        // public static bool NegationValue(string str, bool value)
        // {
        //     if ( str.Length % 2 == 0 )
        //     {
        //         return value;
        //     }
        //
        //     return !value;
        // }

        // public static bool NegationValue(string str, bool value) => str.Length % 2 != 0 ? !value : value;

        // public static bool NegationValue(string str, bool value) => str.Length % 2 == 1 ? !value : value;

        // public static bool NegationValue(string str, bool value)
        // {
        //     if (str.Length%2!=0)
        //     {
        //         value = !value;
        //     }
        //     return value;
        // }

        // public static bool NegationValue(string str, bool value)
        // {   
        //     if(str.Length % 2 == 0) { return value;} else {return !value;}
        // }

        // public static bool NegationValue(string str, bool value)
        // {
        //     bool even = str.Length % 2 == 0;
        //     return (even == value);
        // }
    }
}