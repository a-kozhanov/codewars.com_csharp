/*
https://www.codewars.com/kata/simple-fun-number-2-circle-of-numbers/train/csharp
https://www.codewars.com/kata/58841cb52a077503c4000015/solutions/csharp

7 kyu
Simple Fun #2: Circle of Numbers

Task
Consider integer numbers from 0 to n - 1 written down along the circle in such a way that the distance between any two neighbouring numbers is equal (note that 0 and n - 1 are neighbouring, too).

Given n and firstNumber/first_number, find the number which is written in the radially opposite position to firstNumber.

Example
For n = 10 and firstNumber = 2, the output should be

circleOfNumbers n firstNumber == 7

Input/Output
[input] integer n

A positive even integer.

Constraints: 4 ≤ n ≤ 1000.

[input] integer firstNumber/first_number

Constraints: 0 ≤ firstNumber ≤ n - 1

[output] an integer
*/

namespace CodeWars
{
    public class SimpleFun2CircleOfNumbers
    {
        public int CircleOfNumbers(int circle, int number)
        {
            return (circle / 2 + number) % circle;
        }
    }
}