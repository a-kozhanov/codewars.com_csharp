/*
https://www.codewars.com/kata/541c8630095125aba6000c00/csharp

6 kyu
Sum of Digits / Digital Root

Digital root is the recursive sum of all the digits in a number.

Given n, take the sum of the digits of n. If that value has more than one digit, 
continue reducing in this way until a single-digit number is produced. 
This is only applicable to the natural numbers.

Examples
    16  -->  1 + 6 = 7
   942  -->  9 + 4 + 2 = 15  -->  1 + 5 = 6
132189  -->  1 + 3 + 2 + 1 + 8 + 9 = 24  -->  2 + 4 = 6
493193  -->  4 + 9 + 3 + 1 + 9 + 3 = 29  -->  2 + 9 = 11  -->  1 + 1 = 2
*/

using System.Linq;

namespace CodeWars
{
    public class SumOfDigitsDigitalRoot
    {
        public long DigitalRoot(long n)
        {
            return (n - 1) % 9 + 1;
            //return n < 10 ? n : DigitalRoot(n % 10 + DigitalRoot(n / 10));
            //return n < 10 ? (int) n : DigitalRoot(n.ToString().Select(x => int.Parse(x.ToString())).Sum());
        }
    }
}