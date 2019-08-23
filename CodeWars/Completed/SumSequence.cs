using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


//https://www.codewars.com/kata/sum-of-a-sequence/train/csharp
//https://www.codewars.com/kata/586f6741c66d18c22800010a/solutions/solutions

//Your task is to make function, which returns the sum of a sequence of integers.
//The sequence is defined by 3 non-negative values: begin, end, step.
//If begin value is greater than the end, function should returns 0

//Examples
//SequenceSum(2,2,2); // => 2
//SequenceSum(2,6,2); // => 12 -> 2 + 4 + 6
//SequenceSum(1,5,1); // => 15 -> 1 + 2 + 3 + 4 + 5
//SequenceSum(1,5,3); // => 5 -> 1 + 4

namespace CodeWars
{
    public class SumSequence
    {
        public static int SequenceSum(int start, int end, int step)
        {
            var numbers = new List<int>();
            for (var i = start; i <= end; i += step) numbers.Add(i);
            return numbers.Sum();
        }

        //Best Practices
        //public static int SequenceSum(int start, int end, int step)
        //{
        //    int sum = 0;

        //    for (int i = start; i <= end; i += step)
        //    {
        //        sum += i;
        //    }

        //    return sum;
        //}

    }
}
