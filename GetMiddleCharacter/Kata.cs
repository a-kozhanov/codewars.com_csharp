using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetMiddleCharacter
{
    public class Kata
    {

        public static string getMiddle(string s)
        {
            return string.IsNullOrEmpty(s)
                        ? s
                        : s.Substring((s.Length - 1) / 2, 2 - s.Length % 2);
        }

        public static string getMiddle2(string s)
        {
            int length = s.Length;

            if (length == 1) return s;

            if (length % 2 == 0)
            {
                return s.Substring(length / 2 - 1, 2);
            }
            else
            {
                return s.Substring(length / 2, 1);
            }
        }

    }
}
