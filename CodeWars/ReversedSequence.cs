
//https://www.codewars.com/kata/reversed-sequence/train/csharp
//https://www.codewars.com/kata/5a00e05cc374cb34d100000d/solutions/csharp

//Reversed sequence

//Get the number n (n>0) to return the reversed sequence from n to 1.
//Example : n=5 >> [5,4,3,2,1]

using System.Linq;

namespace CodeWars
{
    public class ReversedSequence
    {
        public static int[] ReverseSeq(int n)
        {
            return Enumerable.Range(1, n).Reverse().ToArray();
        }

        //public static int[] ReverseSeq(int n)
        //{
        //    int[] reversed = new int[n];
        //    for(int i=0;i<n;i++){
        //        reversed[i]=n-i;
        //    }
        //    return reversed;
        //}


        //public static int[] ReverseSeq(int n) => Enumerable.Range(0, n).Select(x => n - x).ToArray();


        //public static int[] ReverseSeq(int n)
        //{
        //    return new int[n].Select(el => el = n--).ToArray();
        //}


        //public static int[] ReverseSeq(int n)
        //{
        //    return (from number in Enumerable.Range(1, n) select number).Reverse().ToArray();
        //}



    }
}