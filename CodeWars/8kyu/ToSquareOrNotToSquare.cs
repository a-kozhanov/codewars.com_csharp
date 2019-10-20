
//https://www.codewars.com/kata/to-square-root-or-not-to-square-root/train/csharp
//https://www.codewars.com/kata/57f6ad55cca6e045d2000627/solutions/csharp

//To square(root) or not to square(root)
//8 kyu

//Write a method, that will get an integer array as parameter and will process every number from this array.
//Return a new array with processing every number of the input-array like this:
//If the number has an integer square root, take this, otherwise square the number.
//[4,3,9,7,2,1] -> [2,9,3,49,4,1]
//The input array will always contain only positive numbers and will never be empty or null.
//The input array should not be modified!
//Have fun coding it and please don't forget to vote and rank this kata! :-)
//I have also created other katas. Take a look if you enjoyed this kata!


using System;
using System.Linq;

namespace CodeWars
{
    public class ToSquareOrNotToSquare
    {
        public static int[] SquareOrSquareRoot(int[] array)
        {
            return array.Select(x => Math.Sqrt(x) % 1 == 0 ? (int)Math.Sqrt(x) : x * x).ToArray();
        }


        //public static int[] SquareOrSquareRoot(int[] array)
        //{
        //    return array.Select(x => (int)(Math.Sqrt(x) % 1 == 0 ? Math.Sqrt(x) : x * x)).ToArray();
        //}


        //public static int[] SquareOrSquareRoot(int[] array)
        //{
        //    return array.Select(e => Sqrt(e)%1 == 0 ? (int)Sqrt(e) : (int)Pow(e, 2)).ToArray();
        //}


        //public static int[] SquareOrSquareRoot(int[] array)
        //{
        //    return array.Select(x => Convert.ToInt32(Math.Sqrt(x)) - Math.Sqrt(x) == 0 
        //        ? Convert.ToInt32(Math.Sqrt(x))
        //        : x*x).ToArray();
        //}







    }
}