/*
https://www.codewars.com/kata/55563df50dda59adf900004d/csharp

7 kyu
EAN Validation

A lot of goods have an International Article Number (formerly known as "European Article Number") abbreviated "EAN". 
EAN is a 13-digits barcode consisting of 12-digits data followed by a single-digit checksum (EAN-8 is not considered in this kata).

The single-digit checksum is calculated as followed (based upon the 12-digit data):

The digit at the first, third, fifth, etc. position (i.e. at the odd position) has to be multiplied with "1".
The digit at the second, fourth, sixth, etc. position (i.e. at the even position) has to be multiplied with "3".
Sum these results.

If this sum is dividable by 10, the checksum is 0. Otherwise the checksum has the following formula:

checksum = 10 - (sum mod 10)

For example, calculate the checksum for "400330101839" (= 12-digits data):

4·1 + 0·3 + 0·1 + 3·3 + 3·1 + 0·3 + 1·1 + 0·3 + 1·1 + 8·3 + 3·1 + 9·3
= 4 + 0 + 0 + 9 + 3 + 0 + 1 + 0 + 1 + 24 + 3 + 27
= 72
10 - (72 mod 10) = 8 ⇒ Checksum: 8

Thus, the EAN-Code is 4003301018398 (= 12-digits data followed by single-digit checksum).

Your Task
Validate a given EAN-Code. Return true if the given EAN-Code is valid, otherwise false.
Assumption
You can assume the given code is syntactically valid, i.e. it only consists of numbers and it exactly has a length of 13 characters.
Examples
EANValidator.Validate("4003301018398") // true
EANValidator.Validate("4003301018392") // false
Good Luck and have fun.
*/

using System.Linq;

namespace CodeWars
{
    public class EANValidation
    {
        public static bool Validate(string eanCode)
        {
            return eanCode
                .Select(c => int.Parse($"{c}"))
                .Select((x, i) => i % 2 == 0 ? x : x * 3)
                .Sum() % 10 == 0;


            // return ((10 - eanCode.Substring(0, 12).Select((d, i) => i % 2 == 0 ? d - '0' : 3 * (d - '0')).Sum() %
            //     10) % 10).ToString() == eanCode.Last().ToString();

            // var s = eanCode.Take(12).Select((c, i) => int.Parse($"{c}") * (i % 2 == 0 ? 1 : 3)).Sum();
            // var n = (s % 10 == 0 ? 0 : 10 - s % 10);
            // return $"{n}" == $"{eanCode.Last()}";

            // if (eanCode.Length != 13) return false;
            // int sum = eanCode
            //     .Remove(eanCode.Length - 1)
            //     .Select(c => (int) char.GetNumericValue(c))
            //     .Select((x, i) => i % 2 == 0 ? x : x * 3)
            //     .Sum();
            // int checksum = sum % 10 == 0 ? 0 : 10 - sum % 10;
            // return checksum == char.GetNumericValue(eanCode.Last());


            // int csum = 0;
            // for (int i = 0; i != 12; ++i)
            // {
            //     csum += (eanCode[i] - '0') * (i % 2 == 0 ? 1 : 3);
            // }
            // return ((csum % 10 == 0) ? 0 : 10 - csum % 10) == (int) (eanCode[12] - '0');
        }
    }
}