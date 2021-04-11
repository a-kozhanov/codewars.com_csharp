/*
https://www.codewars.com/kata/55ffd58d186cc9394f0000cc/csharp

7 kyu
String Calculator

You start work at a new company that receives data monthly in a feed. The feed is fairly old and all of the data comes through as a string.

You are required to create a function that sums the list of comma seperated numbers that arrive in a string and return the result as an int:

AddStrings("12, 5, 3");  //should return: 20
The string passed into your function will only contain numbers in string format and can contain any number of comma seperated integers.
*/

using System.Linq;

namespace CodeWars
{
    public class StringCalculator
    {
        public static int AddStrings(string numbers)
        {
            return numbers.Split(", ").Sum(int.Parse);
        }
    }
}