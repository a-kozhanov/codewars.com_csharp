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
            //return A.GroupBy(c => c, (c, _) => B.Count(v => v == c) / A.Count(v => v == c)).Min();
            //return A.Distinct().Select(c => B.Count(v => v == c) / A.Count(v => v == c)).Min();
            //return A.GroupBy(c => c).Select(g => B.Count(c => c == g.Key) / g.Count()).Min();
            //return A.Distinct().Min(x => B.Count(y => y == x) / A.Count(z => z == x));
            //return A.Select(x => B.Count(y => x == y) / A.Count(y => y == x)).Min();
            //return A.Select(c => B.Count(b => c == b) / A.Count(a => a == c)).Min();
            return A.Min(c => B.Count(b => c == b) / A.Count(a => a == c));
        }
    }
}