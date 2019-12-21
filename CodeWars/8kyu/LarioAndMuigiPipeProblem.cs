/*
https://www.codewars.com/kata/lario-and-muigi-pipe-problem/train/csharp
https://www.codewars.com/kata/56b29582461215098d00000f/solutions/csharp

8 kyu
Lario and Muigi Pipe Problem


#Issue Looks like some hoodlum plumber and his brother has been running around and damaging your stages again.

The pipes connecting your level's stages together need to be fixed before you recieve any more complaints. Each pipe should be connecting, since the levels ascend, you can assume every number in the sequence after the first index will be greater than the previous and that there will be no duplicates.

#Task Given the a list of numbers, return the list so that the values increment by 1 for each index up to the maximum value.

#Example:

Input: 1,3,5,6,7,8

Output: 1,2,3,4,5,6,7,8

*/


using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class LarioAndMuigiPipeProblem
    {
        public static List<int> PipeFix(List<int> numbers)
        {
            return Enumerable.Range(numbers.Min(), numbers.Max() - numbers.Min() + 1).ToList();
        }
    }
}


//using System.Collections.Generic;
//using System.Linq;

//public class Fixer
//{
//    public static List<int> PipeFix(List<int> numbers)
//    {
//        return Enumerable.Range(numbers.First(), numbers.Last() - numbers.First() + 1).ToList();
//    }
//}


//using System.Collections.Generic;
//using System.Linq;

//public class Fixer
//{
//    public static List<int> PipeFix(List<int> numbers)
//    {
//        List<int> rtrn = new List<int>();
//        for (int i = numbers.First(); i <= numbers.Last(); i++)
//        {
//            rtrn.Add(i);
//        }
//        return rtrn;
//    }
//}


//using System.Collections.Generic;
//using System.Linq;
//public class Fixer
//{
//    public static List<int> PipeFix(List<int> n) => Enumerable.Range(n[0], (n[n.Count - 1] - n[0] + 1)).ToList();
//}

