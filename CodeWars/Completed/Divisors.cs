using System;
using System.Threading;

namespace CodeWars
{
    public static class Divisors
    {
        public static int divisors(int n)
        {
            var div = 0;
            for (var i = 1; i <= n; i++)
                if (n % i == 0) div++;

            return div;
        }
    }
}