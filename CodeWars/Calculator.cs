

//https://www.codewars.com/kata/5235c913397cbf2508000048
//

//Calculator

//Create a simple calculator that given a string of operators(), +, -, *, / and numbers separated by spaces returns the value of that expression
//Example:
//Calculator().evaluate("2 / 2 + 3 * 4 - 6") # => 7
//Remember about the order of operations! Multiplications and divisions have a higher priority and should be performed left-to-right.
//Additions and subtractions have a lower priority and should also be performed left-to-right.

//2 / 2 + 3 * 4 - 6
//1-1
//1+1
//1 - 1
//1* 1
//1 /1
//12*-1
//12* 123/-(-5 + 2)
//((80 - (19)))
//(1 - 2) + -(-(-(-4)))
//1 - -(-(-(-4)))
//12* 123/(-5 + 2)
//(123.45*(678.90 / (-2.5+ 11.5)-(((80 -(19))) *33.25)) / 20) - (123.45*(678.90 / (-2.5+ 11.5)-(((80 -(19))) *33.25)) / 20) + (13 - 2)/ -(-11) 
//-123
//123
//2 /2+3 * 4.75- -6
//12* 123
//12 * -123
//2 / (2 + 3) * 4.33 - -6
//((2.33 / (2.9+3.5)*4) - -6)
//123.45*(678.90 / (-2.5+ 11.5)-(80 -19) *33.25) / 20 + 11

namespace CodeWars
{
    public class Calculator
    {
        public double Evaluate(string expression)
        {
            return 0.0;
        }
    }
}