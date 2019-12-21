/*
https://www.codewars.com/kata/printing-array-elements-with-comma-delimiters/train/csharp
https://www.codewars.com/kata/56e2f59fb2ed128081001328/solutions/csharp

8 kyu
Printing Array elements with Comma delimiters

Input: Array of elements
["h","o","l","a"]

Output: String with comma delimited elements of the array in th same order.
"h,o,l,a"
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class PrintingArrayElementsWithCommaDelimiters
    {
        public static string PrintArray(object[] array)
        {
            var list = new List<object>();
            
            foreach (var obj in array)
            {
                var enumerable = obj as IEnumerable;
                if(enumerable != null)
                    foreach(var item in enumerable) list.Add(item.ToString());
                else list.Add(obj.ToString());
            }

            return string.Join(",", list);
        }
            
    }
}


// public static string PrintArray(object[] array)
// {
// return string.Join(",",array.Select(x=>x is Object[]?PrintArray(x as object[]):x));
// }

// public class Kata
// {
//     public static string PrintArray(IEnumerable<object> a) => string.Join(",", a.Select(x => x is IEnumerable<object> ? PrintArray((IEnumerable<object>)x) : x.ToString()));
// }
//

// public static string PrintArray(object[] array)
// {
// return String.Join(",", array.Select(x => x.GetType().ToString() != "System.Object[]" ? x : PrintArray((object[])x)));
// }

// public static string PrintArray(object[] array)
// {
// return string.Join(",", array.Select(o => o is object[] ? PrintArray(o as object[]) : o));
// }