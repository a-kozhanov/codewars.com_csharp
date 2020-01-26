/*
https://www.codewars.com/kata/5a4ea304b3bfa89a9900008e/train/csharp
https://www.codewars.com/kata/5a4ea304b3bfa89a9900008e/solutions/csharp

7 kyu
Form The Largest

Task
Given a number , Return _The Maximum number _ could be formed from the digits of the number given .

Notes
Only Natural numbers passed to the function , numbers Contain digits [0:9] inclusive !alt !alt

Digit Duplications could occur , So also consider it when forming the Largest !alt

Input >> Output Examples:
maxNumber (213) ==> return (321)
Explanation:
As 321 is _The Maximum number _ could be formed from the digits of the number *213*** .

maxNumber (7389) ==> return (9873)
Explanation:
As 9873 is _The Maximum number _ could be formed from the digits of the number *7389*** .

maxNumber (63729) ==> return (97632)
Explanation:
As 97632 is _The Maximum number _ could be formed from the digits of the number *63729*** .

maxNumber (566797) ==> return (977665)
Explanation:
As 977665 is _The Maximum number _ could be formed from the digits of the number *566797*** .

Note : Digit duplications are considered when forming the largest .

maxNumber (17693284) ==> return (98764321)
Explanation:
As 98764321 is _The Maximum number _ could be formed from the digits of the number *17693284*** .

Playing with Numbers Series
Playing With Lists/Arrays Series
For More Enjoyable Katas
ALL translations are welcomed
Enjoy Learning !!
Zizou
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class FormLargest
    {
        public static int MaxNumber(int n)
        {
            //return int.Parse(n.ToString().OrderByDescending(c => c).ToArray());
            return int.Parse($"{n}".OrderByDescending(c => c).ToArray());
        }

        // public static int MaxNumber(int n) => int.Parse(new string(n.ToString().OrderBy(x=>-x).ToArray()));

        // public static int MaxNumber(int n)
        // {
        //     return int.Parse(string.Concat(n.ToString().OrderByDescending(x => char.GetNumericValue(x))));
        // }


        // public static int MaxNumber(int n)=>Convert.ToInt32(string.Concat(n.ToString().OrderByDescending(t=>t)));

        // public static int MaxNumber(int n)
        // {
        //     return Int32.Parse(String.Join("", n.ToString().OrderByDescending(v => v)));
        // }

        // public static int MaxNumber(int n)
        // {
        //     return int.Parse(String.Join("", n.ToString().OrderByDescending(x => x)));
        // }

        // public static int MaxNumber(int n)
        // {
        //     return Int32.Parse(string.Join("", n.ToString().OrderBy(x => x).Reverse()));
        // }
    }
}