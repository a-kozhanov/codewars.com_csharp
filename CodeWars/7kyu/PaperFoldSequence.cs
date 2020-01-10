/*
https://www.codewars.com/kata/the-paperfold-sequence/train/csharp
https://www.codewars.com/kata/5d26721d48430e0016914faa/solutions/csharp

7 kyu
The PaperFold sequence

Wikipedia: The regular paperfolding sequence, also known as the dragon curve sequence, 
is an infinite automatic sequence of 0s and 1s defined as the limit of the following process:

1
1 1 0
1 1 0 1 1 0 0
1 1 0 1 1 0 0 1 1 1 0 0 1 0 0

At each stage an alternating sequence of 1s and 0s is inserted between the terms of the previous sequence.

Define a generator PaperFold that sequentially generates the values of this sequence.

It will be tested for up to 1 000 000 values.
*/

using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class PaperFoldSequence
    {
        public static IEnumerable<int> PaperFold()
        {
            int[] seq = { };
            while (seq.Length < 1000000)
            {
                seq = seq.Append(1).Concat(seq.Reverse().Select(x => x == 0 ? 1 : 0)).ToArray();
            }

            return seq;
        }

        // public static IEnumerable<int> PaperFold() {
        //     for (int i = 1; ; i++)
        //         yield return (i & (i & -i) << 1) != 0 ? 0 : 1;
        // }


        // public static IEnumerable<int> PaperFold()
        // {
        //     int[] arr = new int[] { };
        //     int[] arrClone = new int[] { };
        //     arr = arr.Append(1).ToArray();
        //     while (arr.Count() < 1000000)
        //     {
        //         arrClone = arr.Reverse().Select(x => x == 0 ? 1 : 0).ToArray();               
        //         arr = arr.Append(1).ToArray();
        //         arr = arr.Concat(arrClone).ToArray();              
        //     }       
        //     return arr;
        // }


        // public static IEnumerable<int> PaperFold()
        // {
        //     for(int i = 1; ;i++)
        //     {
        //         var k = i;
        //         var h = k & -k; 
        //         k &= (h << 1);
        //         yield return k == 0 ? 1 : 0;
        //     }
        // }


        // public static IEnumerable<int> PaperFold()
        // {
        //     var sequence = new List<int> { 1 };
        //
        //     while(sequence.Count < 1000000)
        //     {
        //         var temp = sequence.Count;
        //         sequence.Add(1);
        //         for(int index = temp - 1; index >= 0; index--)
        //         {
        //             sequence.Add(sequence[index] * (-1) + 1);
        //         }
        //     }
        //     return sequence;
        // }
    }
}