/*
https://www.codewars.com/kata/5729fa716c7d26dc84000040/csharp

7 kyu
Lowercase strings in array

Create a function to lowercase all strings in an array. Non-string items should remain unchanged.

Example
ArrayLowerCase(new object[] { 'Red', 'Green' }); // => ['red', 'green']
ArrayLowerCase(new object[] { 1, 'Green' }); // => [1, 'green']
*/

using System.Linq;

namespace CodeWars
{
    public class LowercaseStringsInArray
    {
        public static object[] ArrayLowerCase(object[] arr)
        {
            // return arr.Select(o => o as string == null ? o : $"{o}".ToLower()).ToArray();
            // return arr.Select(o => (o is string) ? o.ToString().ToLower() : o).ToArray();
            // return arr.Select(o => o is string ? (o as string).ToLower() : o).ToArray();
            // return arr.Select(o => o is string ? o.ToString()?.ToLower() : o).ToArray();
            // return arr.Select(o => o is string ? ((string) o).ToLower() : o).ToArray();
            // return arr.Select(o => !(o is string) ? o : $"{o}".ToLower()).ToArray();
            return arr.Select(o => (o as string)?.ToLower() ?? o).ToArray();
        }
    }
}