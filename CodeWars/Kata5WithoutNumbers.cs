/*
https://www.codewars.com/kata/5-without-numbers/train/csharp
https://www.codewars.com/kata/59441520102eaa25260000bf/solutions/csharp

8 kyu
5 without numbers !!

Write a function that always returns 5
Sounds easy right? Just bear in mind that you can't use any of the following characters: 0123456789*+-/
Good luck :)
*/

namespace CodeWars
{
    public class Kata5WithoutNumbers
    {
        public static int UnusualFive()
        {
            //return "abcde".Length;
            return 'f' % 'a';
        }
    }
}