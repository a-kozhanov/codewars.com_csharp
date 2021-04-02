/*
https://www.codewars.com/kata/57e2dd0bec7d247e5600013a/csharp

7 kyu
Unflatten a list (Easy)

There are several katas like "Flatten a list". 
These katas are done by so many warriors, that the count of available list to flattin goes down!

So you have to build a method, that creates new arrays, that can be flattened!

#Shorter: You have to unflatten a list/an array.

You get an array of integers and have to unflatten it by these rules:

- You start at the first number.
- If this number x is smaller than 3, take this number x direct 
  for the new array and continue with the next number.
- If this number x is greater than 2, take the next x numbers (inclusive this number) as a 
  sub-array in the new array. Continue with the next number AFTER this taken numbers.
- If there are too few numbers to take by number, take the last available numbers.
The given array will always contain numbers. There will only be numbers > 0.

Example:

 [1,4,5,2,1,2,4,5,2,6,2,3,3] -> [1,[4,5,2,1],2,[4,5,2,6],2,[3,3]]

Steps: 
1. The 1 is added directly to the new array.
2. The next number is 4. So the next 4 numbers (4,5,2,1) are added as sub-array in the new array.
3. The 2 is added directly to the new array.
4. The next number is 4. So the next 4 numbers (4,5,2,6) are added as sub-array in the new array.
5. The 2 is added directly to the new array.
6. The next number is 3. So the next 3 numbers would be taken. There are only 2, 
   so take these (3,3) as sub-array in the new array.
There is a harder version of this kata!
<a href="https://www.codewars.com/kata/57e5aa1d7fbcc988800001ae"taget=_blank>Unflatten a list (Harder than easy)

Have fun coding it and please don't forget to vote and rank this kata! :-)

I have created other katas. Have a look if you like coding and challenges.
*/

using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class UnflattenListEasy
    {
        public static object[] Unflatten(int[] flatArray)
        {
            var result = new List<object>();
            for (var i = 0; i < flatArray.Length; i++)
            {
                if (flatArray[i] < 3) result.Add(flatArray[i]);
                else
                {
                    result.Add(flatArray.Skip(i).Take(flatArray[i]).ToArray());
                    i += flatArray[i] - 1;
                }
            }

            return result.ToArray();
        }
    }
}