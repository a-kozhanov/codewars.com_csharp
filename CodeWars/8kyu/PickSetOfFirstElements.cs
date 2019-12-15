/*
https://www.codewars.com/kata/pick-a-set-of-first-elements/train/csharp
https://www.codewars.com/kata/572b77262bedd351e9000076/solutions/csharp

8 kyu
pick a set of first elements

Write a JavaScript function to get the first element of an array. 
Passing a parameter n (default=1) will return the first n elements of the array. 
If n == 0 return an empty array ([]);

Examples
var arr = new object[] { 'a', 'b', 'c', 'd', 'e' };
Kata.TakeFirstElements(arr); => new object[] { 'a' }
Kata.TakeFirstElements(arr, 2); => new object[] { 'a', 'b' }
Kata.TakeFirstElements(arr, 3); => new object[] { 'a', 'b', 'c' }
Kata.TakeFirstElements(arr, 0); => new object[] { }
Note:
Don't modify array argument.
*/


using System.Linq;

namespace CodeWars
{
    public class PickSetOfFirstElements
    {
        public static object[] TakeFirstElements(object[] array, int n = 1)
        {
            return array.Take(n).ToArray();
        }
    }
}