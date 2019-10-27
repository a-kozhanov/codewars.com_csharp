

//https://www.codewars.com/kata/beginner-reduce-but-grow/train/csharp
//https://www.codewars.com/kata/57f780909f7e8e3183000078/solutions/csharp

//Beginner - Reduce but Grow

//Given a non-empty array of integers, return the result of multiplying the values together in order.Example:
//[1, 2, 3, 4] => 1 * 2 * 3 * 4 = 24

using System.Linq;

namespace CodeWars
{
    public class ReduceButGrow
    {
        public static int Grow(int[] x)
        {

            return x.Aggregate((a, b) => a * b);
        }

        //public static int Grow(int[] x)
        //{
        //    var sum = 1;
        //    for (var i = 0; i < x.Length; i++)
        //    {
        //        sum *= x[i];
        //    }
        //    return sum;
        //}


        //public static int Grow(int[] x)
        //{
        //    int e = 1;
        //    foreach (int c in x) { e *= c; }
        //    return e;
        //}

        //public static int Grow(int[] x)
        //{
        //    int value = 1;
        //    x.OrderBy(y => y).ToList().ForEach(z => value = value * z);
        //    return value;
        //}




    }
}