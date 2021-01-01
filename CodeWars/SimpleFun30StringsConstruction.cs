/*
https://www.codewars.com/kata/58870402c81516bbdb000088/train/csharp

7 kyu
Simple Fun #30: Strings Construction

Task
How many strings equal to A can be constructed using letters from the string B? 
Each letter can be used only once and in one string only.

Example
For A = "abc" and B = "abccba", the output should be 2.

We can construct 2 strings A with letters from B.

Input/Output
[input] string A

String to construct, A contains only lowercase English letters.

Constraints: 3 ≤ A.length ≤ 9.

[input] string B

String containing needed letters, B contains only lowercase English letters.

Constraints: 3 ≤ B.length ≤ 50.

[output] an integer
*/

using System.Linq;

namespace CodeWars
{
    public class SimpleFun30StringsConstruction
    {
        public int StringsConstruction(string A, string B)
        {
            // var r = B.GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count()).Where(x => A.Contains(x.Key)).DefaultIfEmpty()
            //     .Min(x => x.Value);
            // return r;

            return 0;
        }
    }
}