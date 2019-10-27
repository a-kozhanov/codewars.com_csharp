
/*
https://www.codewars.com/kata/short-long-short/train/csharp


8 kyu
Short Long Short

Given 2 strings, a and b, return a string of the form short+long+short, with the shorter string on the outside and the longer string on the inside. 
The strings will not be the same length, but they may be empty ( length 0 ).

For example:

ShortLongShort.Solution("1", "22"); // returns "1221"
ShortLongShort.Solution("22", "1"); // returns "1221"

*/




namespace CodeWars
{
    public class ShortLongShort
    {
        public static string Solution(string a, string b)
        {
            return $"{(a.Length < b.Length ? a : b)}{(a.Length > b.Length ? a : b)}{(a.Length < b.Length ? a : b)}";
        }


        //public static string Solution(string a, string b)
        //{
        //    return (a.Length > b.Length) ? (b + a + b) : (a + b + a);
        //}


        //public static string Solution(string a, string b) => (a.Length > b.Length) ? b + a + b : a + b + a;

        //public static string Solution(string a, string b)
        //{
        //    return (b.Length > a.Length) ? $"{a}{b}{a}" : $"{b}{a}{b}";
        //}

        //public static string Solution(string a, string b)
        //{
        //    string prefix = a.Length > b.Length ? b : a;
        //    string middle = a.Length > b.Length ? a : b;
        //    return $"{prefix}{middle}{prefix}";
        //}


        //public static string Solution(string a, string b)
        //{
        //    return a.Length > b.Length
        //        ? $"{b}{a}{b}"
        //        : $"{a}{b}{a}";
        //}


    }
}