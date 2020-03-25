/*
https://www.codewars.com/kata/58b635903e78b34958000056/train/csharp
https://www.codewars.com/kata/58b635903e78b34958000056/solutions

7 kyu
Simple Fun #172: Count Number

Task
Let's consider a table consisting of n rows and n columns. 
The cell located at the intersection of the i-th row and the j-th column contains number i × j. 
The rows and columns are numbered starting from 1.

You are given a positive integer x. Your task is to count the number of cells in a table that contain number x.

Example
For n = 5 and x = 5, the result should be 2.

The table looks like:

   1  2  3  4  (5)
   2  4  6  8  10
   3  6  9  12 15
   4  8  12 16 20
 (5) 10 15 20 25```
 There are two number `5` in it.

 For `n = 10 and x = 5`, the result should be 2.

 For `n = 6 and x = 12`, the result should be 4.
1 2 3 4 5 6 2 4 6 8 10 (12) 3 6 9 (12) 15 18 4 8 (12) 16 20 24 5 10 15 20 25 30 6 (12) 18 24 30 36

```

Input/Output
[input] integer n

1 ≤ n ≤ 10^5.

[input] integer x

1 ≤ x ≤ 10^9.

[output] an integer

The number of times x occurs in the table.
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class SimpleFun172CountNumber
    {
        public int CountNumber(double n, double x)
        {
            double count = 0, i = 1;

            while (i * i < x)
            {
                if (x % i == 0 && n * i >= x)
                    count += (i <= n ? 1 : 0) + (x / i <= n ? 1 : 0);

                i++;
            }

            return (int) count + (i * i == x && i <= n ? 1 : 0);
        }
    }
}