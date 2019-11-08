
/*
https://www.codewars.com/kata/dollars-and-cents/train/csharp
https://www.codewars.com/kata/55902c5eaa8069a5b4000083/solutions/csharp

8 kyu
Dollars and Cents

The company you work for has just been awarded a contract to build a payment gateway. In order to help move things along, you have volunteered to create a function that will take a float and return the amount formatting in dollars and cents.

39.99 becomes $39.99

The rest of your team will make sure that the argument is sanitized before being passed to your function although you will need to account for adding trailing zeros if they are missing (though you won't have to worry about a dangling period).

Examples:

3 needs to become $3.00

3.1 needs to become $3.10
Good luck! Your team knows they can count on you!

*/


using System;
using System.Globalization;

namespace CodeWars
{
    public class DollarsAndCents
    {
        public static string FormatMoney(double amount)
        {
            var nfi = new CultureInfo("en-US", false).NumberFormat;
            nfi.CurrencyGroupSeparator = "";
            return string.Format(nfi, "{0:C}", amount);
        }


        //public static string FormatMoney(double amount) => $"${amount:F2}";

        //public static string FormatMoney(double amount)
        //{
        //    return amount.ToString("$0.00");
        //}

        //public static string FormatMoney(double amount)
        //{
        //    return string.Format("{0}{1:0.00}", "$", amount);
        //}

        //public static string FormatMoney(double amount)
        //{
        //    return String.Format("${0:f}", amount);
        //}

        //public static string FormatMoney(double amount)
        //{
        //    return $"${string.Format("{0:F2}", amount)}";
        //}

        //public static string FormatMoney(double amount)
        //{
        //    return string.Format("{0:$0.00}",amount);
        //}
    }
}