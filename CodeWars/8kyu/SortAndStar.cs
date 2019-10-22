
//https://www.codewars.com/kata/sort-and-star/train/csharp
//https://www.codewars.com/kata/57cfdf34902f6ba3d300001e/solutions/csharp

//Sort and Star
//8 kyu

using System;
using System.Linq;

namespace CodeWars
{
    public class SortAndStar
    {
        static int Comparer(string s1, string s2)
        {
            if (char.IsUpper(s1[0]) && char.IsLower(s2[0])) return -1;
            if (char.IsUpper(s2[0]) && char.IsLower(s1[0])) return 1;
            return String.CompareOrdinal(s1, s2);
        }

        public static string TwoSort(string[] s)
        {
            var list = s.ToList();
            list.Sort(Comparer);
            return string.Join("***", list.First().Select(c => c));
        }


        //public static string TwoSort(string[] s)
        //{
        //    return string.Join("***", s.OrderBy(a => a, StringComparer.Ordinal).First().ToArray());
        //}  


        //public static string TwoSort(string[] s)
        //{
        //    System.Array.Sort(s, StringComparer.Ordinal);
        //    char[] c = s[0].ToCharArray();
        //    return string.Join("***", c);
        //} 


        //public static string TwoSort(string[] s)=>
        //    string.Join("***", s.OrderBy(a => a, StringComparer.Ordinal).First().ToArray());


        //public static string TwoSort(string[] s)
        //{
        //    return string.Join("***", s.OrderBy(x => x, StringComparer.Ordinal).First().ToArray());
        //}



    }
}