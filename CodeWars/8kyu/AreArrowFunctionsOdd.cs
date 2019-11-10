
/*
https://www.codewars.com/kata/are-arrow-functions-odd/train/javascript
https://www.codewars.com/kata/559f80b87fa8512e3e0000f5/solutions/csharp

8 kyu
Are arrow functions odd?

Time to test your basic knowledge in functions! Return the odds from a list:
Kata.Odds(new List<int> {1,2,3,4,5}) => new List<int> {1,3,5};
*/


using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class AreArrowFunctionsOdd
    {
        public static List<int> Odds(List<int> values) => values.Where(x => x % 2 == 1).ToList();
    }


    //public static List<int> Odds(List<int> values) =>
    //values.Where(q => q % 2 != 0)
    //.ToList();


    //public static List<int> Odds(List<int> values) =>
    //// arrow it
    //values.Where(x => x % 2 == 1)
    //.ToList();


    //public static List<int> Odds(List<int> values) =>
    //// arrow it
    //values.Where(s => s % 2 == 1)
    //.ToList();


    //public static List<int> Odds(List<int> values)
    //{
    //    return values.Where(x => x % 2 == 1).ToList();
    //}

}