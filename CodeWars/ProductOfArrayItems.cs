/*
https://www.codewars.com/kata/5901f361927288d961000013/train/csharp
https://www.codewars.com/kata/5901f361927288d961000013/solutions/csharp

7 kyu
Product of Array Items

Calculate the product of all elements in an array.

If the array is null, you should throw ArgumentNullException and if the array is empty, 
you should throw InvalidOperationException.

As a challenge, try writing your method in just one line of code. 
It's possible to have only 36 characters within your method.
*/

using System.Linq;

namespace CodeWars
{
    public class ProductOfArrayItems
    {
        public static int Product(int[] values)
        {
            return values.Aggregate((x, y) => x * y);
        }
    }
}