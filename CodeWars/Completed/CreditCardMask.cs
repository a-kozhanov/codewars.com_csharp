
//https://www.codewars.com/kata/credit-card-mask/train/csharp
//https://www.codewars.com/kata/5412509bd436bd33920011bc/solutions/csharp

//Credit Card Mask

//Usually when you buy something, you're asked whether your credit card number, phone number or answer to your
//most secret question is still correct. However, since someone could look over your shoulder, you don't want that shown on your screen.Instead, we mask it.
//Your task is to write a function maskify, which changes all but the last four characters into '#'.

//Examples
//Kata.Maskify('4556364607935616'); // should return "############5616"
//Kata.Maskify('64607935616');      // should return "#######5616"
//Kata.Maskify('1');                // should return "1"
//Kata.Maskify('');                 // should return ""

//// "What was the name of your first pet?"
//Kata.Maskify('Skippy');                                   // should return "##ippy"
//Kata.Maskify('Nananananananananananananananana Batman!'); // should return "####################################man!"


using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    public class CreditCardMask
    {
        public static string Maskify(string cc)
        {
            for (int i = 0; i <= cc.Length - 5; i++)
            {
                cc = cc.Remove(i, 1).Insert(i, "#");
            }

            return cc;
        }

        //Best Practices
        //public static string Maskify(string cc)
        //{
        //    int len = cc.Length;
        //    if (len <= 4)
        //        return cc;

        //    return cc.Substring(len - 4).PadLeft(len, '#');
        //}


        //public static string Maskify(string cc)
        //{
        //    return cc.Substring(cc.Length < 4 ? 0 : cc.Length - 4).PadLeft(cc.Length, '#');
        //}


        //public static string Maskify(string cc)
        //{
        //    var cs = cc.ToCharArray();

        //    for (int i = 0; i < cc.Length - 4; i++)
        //    {
        //        cs[i] = '#';
        //    }

        //    return string.Concat(cs);
        //}


        //public static string Maskify(string cc)
        //{
        //    return cc.Length > 4 ? cc.Substring(cc.Length - 4).PadLeft(cc.Length, '#') : cc;
        //}

        //public static string Maskify(string cc)
        //{
        //    return Regex.Replace(cc, ".(?=.{4})", "#");
        //}


        //public static string Maskify(string cc)
        //{
        //    return new string(cc
        //        .ToCharArray()
        //        .Select((x, i) => i < cc.Length - 4 ? '#' : x)
        //        .ToArray());
        //}

    }
}