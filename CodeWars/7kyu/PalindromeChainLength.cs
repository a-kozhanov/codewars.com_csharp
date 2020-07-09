/*
https://www.codewars.com/kata/525f039017c7cd0e1a000a26/csharp

7 kyu
Palindrome chain length

Number is a palindrome if it is equal to the number with digits in reversed order. 
For example, 5, 44, 171, 4884 are palindromes and 43, 194, 4773 are not palindromes.

Write a method palindrome_chain_length which takes a positive number and returns the number of special steps needed to obtain a palindrome. 
The special step is: "reverse the digits, and add to the original number". 
If the resulting number is not a palindrome, repeat the procedure with the sum until the resulting number is a palindrome.
If the input number is already a palindrome, the number of steps is 0.
Input will always be a positive integer.
For example, start with 87:
87 + 78 = 165; 165 + 561 = 726; 726 + 627 = 1353; 1353 + 3531 = 4884
4884 is a palindrome and we needed 4 steps to obtain it, so palindrome_chain_length(87) == 4
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class PalindromeChainLength
    {
        public static int palindromeChainLength(ulong n)
        {
            //return $"{n}" == string.Concat($"{n}".Reverse()) ? count : 1 + palindromeChainLength(n + ulong.Parse(n.ToString().Reverse().ToArray()));


            var reversed = ulong.Parse(string.Concat($"{n}".Reverse()));
            return reversed == n ? 0 : 1 + palindromeChainLength(n + reversed);


            // Console.WriteLine(n);
            // var count = 0;
            // while ($"{n}" != string.Concat($"{n}".Reverse()))
            // {
            //     n += ulong.Parse(n.ToString().Reverse().ToArray());
            //     count++;
            // }
            // return count;
        }
    }
}