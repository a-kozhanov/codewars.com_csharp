
/*
https://www.codewars.com/kata/filling-an-array-part-1/train/csharp
https://www.codewars.com/kata/571d42206414b103dc0006a1/solutions/csharp

8 kyu
Filling an array (part 1)

We want an array, but not just any old array, an array with contents!
Write a function that produces an array with the numbers 0 to N-1 in it.
For example, the following code will result in an array containing the numbers 0 to 4:
arr(5) // => [0,1,2,3,4]

*/

using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class FillingAnArrayPart1
    {
        public static int[] Arr(int N)
        {
            return Enumerable.Range(0, N).ToArray();
        }

        //public static int[] Arr(int N)
        //{
        //    List<int> newInt = new List<int>();
        //    for(int i = 0; i <= N-1; i++)
        //    {
        //        newInt.Add(i);
        //    }
        //    return newInt.ToArray();
        //}
    }
}