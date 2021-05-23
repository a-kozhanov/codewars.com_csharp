/*
https://www.codewars.com/kata/599b479ec2bd3ae0b000000b/csharp

7 kyu
ASCII-ing on the Alps

The summer heat is a great time to daydream about flying down the snowy slopes. Let's build A-SCII resort!

First things first, though, we need to figure out what kind of slopes we're putting in. The marketing team has already come up with some catchy names, 
but we need to make sure that we're assigning them to the right slopes.

Slopes have C.O.O.L. ratings, which stants for Conversion Of Only Letters. 
Based on the incline, (2, 8, 10, or 16) and the name provided, assign a C.O.O.L. rating.

C.O.O.L. rating is calulated by converting each character of the string to its ASCII value, then taking a sum, 
then converting the resulting number to the base indicated by the incline.

Example: 2, Cool => C o o l => 67 111 111 108 => 397 => "110001101"

Assumptions and Edgecases: You may assume that the incline will only ever be 2, 8, 10, or 16. 
You may also assume that the input will be a strictly alpha string. If the string is empty, return 0.

Have fun, kids, and remember to wear a helmet!
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class ASCIIingOnAlps
    {
        public static string DetermineCool(int incline, string name)
        {
            // return Convert.ToString(name.Aggregate(0, (i, c) => i + c), incline);
            // return Convert.ToString(name.Select(c => (int) c).Sum(), incline);
            return Convert.ToString(name.Sum(c => c), incline);
        }
    }
}