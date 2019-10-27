
//https://www.codewars.com/kata/greatest-common-divisor/train/csharp
//https://www.codewars.com/kata/5500d54c2ebe0a8e8a0003fd/solutions/csharp

//Greatest common divisor

//Find the greatest common divisor of two positive integers.The integers can be large, so you need to find a clever solution.
//The inputs x and y are always greater or equal to 1, so the the greatest common divisor will always be an integer that is also greater or equal to 1.


namespace CodeWars
{
    public class GreatestCommonDivisor
    {
        public static int Gcd(int a, int b)
        {
            return b == 0 ? a : Gcd(b, a % b);
        }

    }
}