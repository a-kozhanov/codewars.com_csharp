
//https://www.codewars.com/kata/get-nth-even-number/train/csharp
//https://www.codewars.com/kata/5933a1f8552bc2750a0000ed/solutions/csharp

//Get Nth Even Number

//Return the Nth Even Number
//NthEven(1) //=> 0, the first even number is 0
//NthEven(3) //=> 4, the 3rd even number is 4 (0, 2, 4)
//NthEven(100) //=> 198
//NthEven(1298734) //=> 2597466
//The input will not be 0.


using System;

namespace CodeWars
{
    public class GetNthEvenNumber
    {
        public static int NthEven(int n)
        {
            var nth = 0;

            for (var i = 1; i < n; i++)
            {
                nth += 2;
            }

            return nth;
        }


        //public static int NthEven(int n)
        //{
        //    return 2 * (n - 1);
        //}


        //public static int NthEven(int n) => 2 * (n - 1);


        //public static int NthEven(int n)
        //{
        //    return n + n - 2;
        //}


        //public static int NthEven(int n)
        //{
        //    return (n - 1) * 2;
        //}


        //public static int NthEven(int n)
        //{
        //    return (n * 2) - 2;
        //}

    }
}