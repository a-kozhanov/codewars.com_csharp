/*
https://www.codewars.com/kata/54d418bd099d650fa000032d/csharp

7 kyu
Vampire Numbers

Vampire Numbers
Our loose definition of Vampire Numbers can be described as follows:

6 * 21 = 126
# 6 and 21 would be valid 'fangs' for a vampire number as the 
# digits 6, 1, and 2 are present in both the product and multiplicands

10 * 11 = 110
# 110 is not a vampire number since there are three 1's in the
# multiplicands, but only two 1's in the product
Create a function that can receive two 'fangs' and determine if the product of the two is a valid vampire number.
*/

using System.Linq;

namespace CodeWars
{
    public class VampireNumbers
    {
        public static bool vampire_test(long x, long y)
        {
            //return string.Concat($"{x}{y}".OrderBy(c => c)).Equals(string.Concat((x * y).ToString().OrderBy(c => c)));
            //return string.Concat($"{x}{y}".OrderBy(c => c)) == string.Concat($"{x * y}".OrderBy(c => c));
            //return (x * y).ToString().OrderBy(c => c).SequenceEqual((x.ToString() + y).OrderBy(c => c));
            //return Enumerable.SequenceEqual($"{x}{y}".OrderBy(c => c), $"{x * y}".OrderBy(c => c));
            //return $"{x * y}".OrderBy(c => c).SequenceEqual($"{x}{y}".OrderBy(c => c));
            return $"{x}{y}".OrderBy(c => c).SequenceEqual($"{x * y}".OrderBy(c => c));
        }
    }
}