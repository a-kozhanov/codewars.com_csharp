using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeWars
{
    public class FindDivisors
    {
        public static int[] Divisors(int n)
        {
            //var div = Enumerable.Range(2, n / 2).Where(a => n % a == 0).ToArray();
            //if (div.Count() > 0)
            //    return div.ToArray();
            //else return new int[] { };
            return Enumerable.Range(2, n / 2).Where(a => n % a == 0).ToArray();
        }
    }
}
