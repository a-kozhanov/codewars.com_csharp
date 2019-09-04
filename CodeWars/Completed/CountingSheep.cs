using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//https://www.codewars.com/kata/counting-sheep-dot-dot-dot/train/csharp
//https://www.codewars.com/kata/54edbc7200b811e956000556/solutions/csharp

//Counting sheep...

//Consider an array of sheep where some sheep may be missing from their place.We need a function that counts the number of sheep present in the array (true means present).

//For example,
//[true, true, true, false,
//true, true, true, true,
//true, false, true, false,
//true, false, false, true,
//true, true, true, true,
//false, false, true, true]
//The correct answer would be 17.

//Hint: Don't forget to check for bad values like null/undefined

namespace CodeWars
{
    public class CountingSheep
    {
        public static int CountSheeps(bool[] sheeps)
        {
            return sheeps.Count(s => s);
        }
        //Best Practices

    }
}
