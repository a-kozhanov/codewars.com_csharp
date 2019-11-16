/*
https://www.codewars.com/kata/filtering-even-numbers-bug-fixes/train/csharp
https://www.codewars.com/kata/566dc566f6ea9a14b500007b/solutions/csharp

8 kyu
Filtering even numbers (Bug Fixes)

Fix the bug in Filtering method
The method is supposed to remove even numbers from the list and return a list that contains odd number.

However, there is a bug in the method that needs to be resolved.
*/

using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class FilteringEvenNumbers
    {
        public static List<int> FilterOddNumber(List<int> listOfNumbers)
        {
            return listOfNumbers.Where(x => x % 2 == 1).ToList();

            //for (int i = 0; i < listOfNumbers.Count; i++)
            //{
            //    if (listOfNumbers[i] % 2 == 1)
            //    {
            //        listOfNumbers.RemoveAt(i);
            //    }
            //}
            //return listOfNumbers;
        }

        //public static List<int> FilterOddNumber(List<int> listOfNumbers)
        //{
        //    for (int i = 0; i < listOfNumbers.Count; i++)
        //    {
        //        if (listOfNumbers[i] % 2 == 0)
        //        {
        //            listOfNumbers.RemoveAt(i--);
        //        }
        //    }
        //    return listOfNumbers;
        //}


    }
}