
//https://www.codewars.com/kata/fake-binary/train/csharp
//https://www.codewars.com/kata/57eae65a4321032ce000002d/solutions/csharp

//Fake Binary

//Given a string of digits, you should replace any digit below 5 with '0' and any digit 5 and above with '1'. Return the resulting string.

using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class FakeBinary
    {
        public static string FakeBin(string x)
        {
            var sb = new StringBuilder();
            foreach (var n in x)
            {
                if (int.Parse(n.ToString()) < 5) sb.Append(0);
                if (int.Parse(n.ToString()) >= 5) sb.Append(1);
            }
            return sb.ToString();
        }

        //public static string FakeBin(string x)
        //{
        //    return string.Concat(x.Select(a => a < '5' ? "0" : "1"));
        //}


        //public static string FakeBin(string x)
        //{
        //    StringBuilder builder = new StringBuilder();
        //    foreach (char t in x)
        //    {
        //        builder.Append(t >= '5' ? '1' : '0');
        //    }
        //    return builder.ToString();
        //}


        //public static string FakeBin(string x)
        //{
        //    string result = "";

        //    foreach (char c in x)
        //        result += c < '5' ? "0" : "1";

        //    return result;
        //}


        //public static string FakeBin(string x)
        //{
        //    x = Regex.Replace(x, "[4321]", "0");
        //    x = Regex.Replace(x, "[56789]", "1");
        //    return x;
        //}


        //public static string FakeBin(string x)
        //{
        //    string binString = "";
        //    foreach (char c in x.ToCharArray())
        //    {
        //        int num = (int)char.GetNumericValue(c);
        //        binString += num < 5 ? 0 : 1;
        //    }
        //    return binString;
        //}


        //public static string FakeBin(string x)
        //{
        //    Regex pattern = new Regex("[01234]");
        //    x = pattern.Replace(x, "0");

        //    pattern = new Regex("[56789]");
        //    return x = pattern.Replace(x, "1");
        //}


        //public static String FakeBin(String input)
        //    => String.Join("", input.Select(x => Int32.Parse(x.ToString()) < 5 ? '0' : '1'));


        //public static string FakeBin(string x)
        //{
        //    var builder = new StringBuilder(x);
        //    for (int i = 0; i < builder.Length; ++i)
        //    {
        //        builder[i] = builder[i] < '5' ? '0' : '1';
        //    }
        //    return builder.ToString();
        //}


        //public static string FakeBin(string x)
        //{
        //    return x.Replace('4', '0').Replace('3', '0').Replace('2', '0').Replace('1', '0').Replace('5', '1').Replace('6', '1').Replace('7', '1').Replace('8', '1').Replace('9', '1');
        //}


        //public static string FakeBin(string x)
        //{
        //    string result = "";
        //    for (int i = 0; i < x.Length; i++) result += Int32.Parse(x[i].ToString()) < 5 ? "0" : "1";
        //    return result;
        //}

        //public static string FakeBin(string x)
        //{
        //    return Regex.Replace(Regex.Replace(x, "[1-4]", "0"), "[5-9]", "1");
        //}


        //public static string FakeBin(string x)
        //{
        //    return string.Concat(x.Select(c => c < '5' ? '0' : '1'));
        //}

        //public static string FakeBin(string x)
        //{
        //    return string.Join("", x.Select(a => a < '5' ? '0' : '1'));
        //}

        //public static string FakeBin(string x)
        //{
        //    return string.Concat(x.Select(d => d / '5'));
        //}



    }
}
