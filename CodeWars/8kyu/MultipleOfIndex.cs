//https://www.codewars.com/kata/5a34b80155519e1a00000009
//https://www.codewars.com/kata/5a34b80155519e1a00000009/solutions/csharp

//Multiple of index
//8 kyu


//Return a new array consisting of elements which are multiple of their own index in input array (length > 1).
//Some cases:
//[22, -6, 32, 82, 9, 25] =>  [-6, 32, 25]
//[68, -1, 1, -7, 10, 10] => [-1, 10]
//[-56,-85,72,-26,-14,76,-27,72,35,-21,-67,87,0,21,59,27,-92,68] => [-85, 72, 0, 68]

using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class KataMultipleOfIndex
    {
        public static List<int> MultipleOfIndex(List<int> xs)
        {
            //var result = new List<int>();
            //for (var i = 1; i < xs.Count; i++)
            //{
            //    if (xs[i] % i == 0) result.Add(xs[i]);
            //}
            //return result;

            return xs.Select((v, i) => new { Index = i, Value = v }).Where(x => x.Index > 0 && x.Value % x.Index == 0).Select(p => p.Value).ToList();
        }


        //public static List<int> MultipleOfIndex(List<int> xs)
        //{
        //    return xs.Skip(1).Where((x, i) => x % (i + 1) == 0).ToList();
        //}


        //public static List<int> MultipleOfIndex(List<int> xs)
        //{
        //    return xs.Where((v, i) => i != 0 && v % i == 0).ToList();
        //}


        //public static List<int> MultipleOfIndex(List<int> xs)
        //{
        //    return xs.Where((x, i) => i != 0 && x % i == 0).ToList();
        //}


        //public static List<int> MultipleOfIndex(List<int> xs)
        //{
        //    return xs
        //        .Select((val, id) => new {val, id})
        //        .Skip(1)
        //        .Where(v => v.val % v.id == 0)
        //        .Select(v => v.val)
        //        .ToList();
        //}


        //public static List<int> MultipleOfIndex(List<int> xs)
        //{
        //    return xs.Where((t, i) => i > 0 && t % i == 0).ToList();
        //}





    }
}