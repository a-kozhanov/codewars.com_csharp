
//https://www.codewars.com/kata/count-the-monkeys/train/csharp
//https://www.codewars.com/kata/56f69d9f9400f508fb000ba7/solutions/csharp

//Count the Monkeys!

//You take your son to the forest to see the monkeys. You know that there are a certain number there (n), but your son is too young to just appreciate the full number, he has to start counting them from 1.
//As a good parent, you will sit and count with him. Given the number (n), populate an array with all numbers up to and including that number, but excluding zero.
//For example:
//monkeyCount(10) // --> new int[]{1, 2, 3, 4, 5, 6, 7, 8, 9, 10}
//monkeyCount(1) // --> new int[]{1}

using System.Linq;

namespace CodeWars
{
    public class MonkeyCounter
    {
        public static int[] MonkeyCount(int n)
        {
            return Enumerable.Range(1, n).ToArray();
        }

        //        public static int[] MonkeyCount(int n) => Enumerable.Range(1, n).ToArray();

        //        public static int[] MonkeyCount(int n)
        //        {
        //            int[] numbers = new int[n];
        //  
        //            for(int count = 1; count <= n; count++)
        //            {
        //                numbers[count - 1] = count;
        //            }
        //            return numbers;
        //        }
        //
        //
        //        public static int[] MonkeyCount(int n)
        //        {
        //            int count = 1;
        //            int[] array = new int[n];
        //            while (count <= n) {
        //                array[count-1] = count;
        //                count++;
        //            }
        //            return array;
        //        }

        //
        //        public static int[] MonkeyCount(int n)
        //        {
        //    
        //            int[] mas = new int[n];
        //            for (int i=0;i<n;i++)
        //            {
        //                mas[i] = i+1;
        //            }
        //            return mas;
        //        }
        //
        //
        //        public static int[] MonkeyCount(int n)
        //        {
        //            int[] MonkeyCountScore = new int[n];
        //            for (int i=1;i<=n;i++)
        //            {
        //                MonkeyCountScore[i-1] = i;
        //            }
        //            return MonkeyCountScore;
        //        }




    }
}