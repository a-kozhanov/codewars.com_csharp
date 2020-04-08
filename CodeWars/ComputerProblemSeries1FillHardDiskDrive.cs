/*
https://www.codewars.com/kata/5d49c93d089c6e000ff8428c/train/csharp
 
7 kyu
Computer problem series #1: Fill the Hard Disk Drive

Your task is to determine how many files of the copy queue you will be able to save into your Hard Disk Drive.

Input:
Array of file sizes (0 <= s <= 100)
Capacity of the HD (0 <= c <= 500)
Output:
Number of files that can be fully saved in the HD

Examples:
save([4,4,4,3,3], 12) -> 3
# 4+4+4 <= 12, but 4+4+4+3 > 12

save([4,4,4,3,3], 11) -> 2
# 4+4 <= 11, but 4+4+4 > 11

Do not expect any negative or invalid inputs.
*/

using System.Linq;

namespace CodeWars
{
    public class ComputerProblemSeries1FillHardDiskDrive
    {
        public static int Save1(int[] sizes, int hd)
        {
            //return sizes.TakeWhile((x, i) => sizes.Take(i + 1).Sum() <= hd).Count();
            //return Enumerable.Range(0, sizes.Length).Count(i => sizes.Take(i + 1).Sum() <= hd);
            //return sizes.Where((x, i) => sizes.Take(i + 1).Sum() <= hd).Count();
            return sizes.Aggregate((x, y) => x + y);
        }


        public static int Save(int[] sizes, int hd)
        {
            var sum = 0;
            var count = 0;

            foreach (var t in sizes)
            {
                sum += t;
                if (sum <= hd) count++;
                else break;
            }

            return count;
        }
    }
}