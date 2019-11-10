
/*
https://www.codewars.com/kata/a-plus-b/discuss/csharp
https://www.codewars.com/kata/5512a0b0509063e57d0003f5/solutions/csharp

8 kyu
A + B

Vasya Pupkin just started learning Java and C#. 
At first, he decided to write simple program that was supposed to sum up two small numbers (numbers and their sum fit in a byte), 
but it didn't work. Vasya was too sad to find out what is wrong. 
Help him to correct the mistake.

*/

namespace CodeWars
{
    public class APlusB
    {
        public static byte sum(byte a, byte b) => (byte)(a + b);
    }
}