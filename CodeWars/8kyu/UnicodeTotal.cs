

//https://www.codewars.com/kata/unicode-total/train/csharp
//https://www.codewars.com/kata/572b6b2772a38bc1e700007a/solutions/csharp

//8 kyu
//Unicode Total


//You'll be given a string, and have to return the total of all the unicode characters as an int. Should be able to handle any characters sent at it.
//examples:
//uniTotal("a") == 97 uniTotal("aaa") == 291


using System;
using System.Linq;

namespace CodeWars
{
    public class UnicodeTotal
    {
        public static int UniTotal(string str)
        {
            return str.Sum(c => c);
        }


        //public static int UniTotal(string str) => str.Sum(x => (int)x);


        //public static int UniTotal(string s) => s.Sum(Convert.ToInt32);

        //public static int UniTotal(string str)
        //{
        //    return str.Sum(c => (int)c);
        //}





    }
}