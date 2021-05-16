/*
https://www.codewars.com/kata/56aaf25213edd3a88a000002/csharp

7 kyu
Zip it!

Write

that merges the corresponding elements of two sequences using a specified selector function fn (a block in Ruby)

For example:

var a = new object[] { 1, 2, 3, 4, 5 };
var b = new object[] { 'a','b' };
a.ZipIt(b, (c, d) => c + "" + d); --> new object[] { '1a', '2b' }

var a = new object[] { 1, 2, 3, 4, 5 };
var b = new object[] {'a','b','c','d','e'};
a.ZipIt(b, (c, d) => (int)c + (int)(char)d)); --> new object[] { 98, 100, 102, 104, 106 }
if arrays have different lengths, go up to the minimum length and then stop.
*/

using System;
using System.Linq;

namespace CodeWars
{
    public static class KataZipIt
    {
        public static object[] ZipIt(this object[] a, object[] b, Func<object, object, object> fn)
        {
            return a.Zip(b, fn).ToArray();
            // return Enumerable.Zip(a, b, fn).ToArray();
            // return a.Zip(b).Select(x => fn(x.First, x.Second)).ToArray();
        }
    }
}