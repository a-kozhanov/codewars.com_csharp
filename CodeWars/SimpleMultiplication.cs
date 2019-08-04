
//https://www.codewars.com/kata/simple-multiplication/train/csharp
//https://www.codewars.com/kata/583710ccaa6717322c000105/solutions/csharp

//Simple multiplication

//This kata is about multiplying a given number by eight if it is an even number and by nine otherwise.


namespace CodeWars
{
    public class SimpleMultiplication
    {
        public static int Multiply(int x)
        {
            return x % 2 == 1 ? x * 9 : x * 8;
        }

        ////public static int Multiply(int x)
        ////{
        ////    return x * (8 + x % 2);
        ////}

        ////public static int Multiply(int x) => x * ((x % 2) + 8);

        ////public static int Multiply(int x) 
        ////{
        ////    return x * (x % 2 == 1 ? 9 : 8);
        ////}

        ////public static int Multiply(int x) 
        ////{
        ////    return x * ((x & 1) == 0 ? 8 : 9);
        ////}

    }
}