/*
https://www.codewars.com/kata/javascript-array-filter/train/csharp
https://www.codewars.com/kata/514a6336889283a3d2000001/solutions/csharp

7 kyu
JavaScript Array Filter

Starting with .NET Framework 3.5, C# supports a Where (in the System.Linq namespace) method which allows a user to filter arrays based on a predicate. 
Use the Where method to complete the function given.

Enumerable.Where documentation: https://msdn.microsoft.com/en-us/library/bb534803(v=vs.110).aspx

The solution would work like the following:
Kata.GetEvenNumbers(new int[] {2, 4, 5, 6}) => new int[] {2, 4, 6}
*/

using System.Linq;

namespace CodeWars
{
    public class JavaScriptArrayFilter
    {
        public static int[] GetEvenNumbers(int[] numbers)
        {
            return numbers.Where(n => n % 2 == 0).ToArray();
        }

        // public static int[] GetEvenNumbers(int[] numbers) => numbers.Where(x => (x & 1) == 0).ToArray();
    }
}