/*
https://www.codewars.com/kata/58884e352ffea6d2f8000082/csharp

7 kyu
Simple Fun #48: Higher Version

Task
Given two version strings composed of several non-negative decimal fields separated by periods ("."), both strings contain equal number of numeric fields.

Return true if the first version is higher than the second version and false otherwise.

The syntax follows the regular semver ordering rules:

1.0.5 < 1.1.0 < 1.1.5 < 1.1.10 < 1.2.0 < 1.2.2
        < 1.2.10 < 1.10.2 < 2.0.0 < 10.0.0
There are no leading zeros in any of the numeric fields, i.e. you do not have to handle inputs like 100.020.003 (it would instead be given as 100.20.3).

Example
For ver1 = "1.2.2" and ver2 = "1.2.0", the output should be true;

For ver1 = "1.0.5" and ver2 = "1.1.0", the output should be false.

Input/Output
[input] string ver1

[input] string ver2

[output] a boolean value
*/

using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class SimpleFun48HigherVersion
    {
        public bool HigherVersion(string ver1, string ver2)
        {
            return ver1.Split('.').Select(int.Parse)
                .Zip(ver2.Split('.').Select(int.Parse), (x, y) => x - y)
                .FirstOrDefault(x => x != 0) > 0;


            // var v1 = ver1.Split('.').Select(int.Parse).ToArray();
            // var v2 = ver2.Split('.').Select(int.Parse).ToArray();
            //
            // for (var i = 0; i < v1.Length; i++)
            // {
            //     if (v1[i] == v2[i]) continue;
            //     return v1[i] > v2[i];
            // }
            //
            // return false;
        }
    }
}