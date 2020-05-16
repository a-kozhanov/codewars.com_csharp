/*
https://www.codewars.com/kata/54e9554c92ad5650fe00022b/csharp

7 kyu
Converting integer to currency format

Write a function that takes an integer in input and outputs a string with currency format.

Integer in currency format is expressed by a string of number where every three characters are separated by comma.

For example:

123456 --> "123,456"
Input will always be an positive integer, so don't worry about type checking or negative/float values.
*/

using System.Globalization;

namespace CodeWars
{
    public class ConvertingIntegerToCurrencyFormat
    {
        public static string ToCurrency(int price)
        {
            //return price.ToString("N0", CultureInfo.CreateSpecificCulture("en-En"));
            //return price.ToString("N0", CultureInfo.GetCultureInfo("en"));
            //return price.ToString("N0");
            return $"{price:N0}";
        }
    }
}