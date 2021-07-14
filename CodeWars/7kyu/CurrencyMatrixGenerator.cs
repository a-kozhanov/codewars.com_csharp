/*
https://www.codewars.com/kata/57bec3bc5640aa5f3f00003e/csharp

7 kyu
Currency Matrix Generator

On the Forex Market the currency symbols for exchange between two currencies are put together in regards to their strength and weakness. 
The order of the currency strength is as follows:

"EUR", "GBP", "AUD", "NZD", "USD", "CAD", "CHF", "JPY"

So for AUD the currency matrix would be as follows EURAUD, GBPAUD, AUDNZD, AUDUSD, AUDCAD, AUDCHF, AUDJPY

Your goal is to generate this currency matrix for a given currency. 
You can assume that the passed in currency is a valid one.
*/

using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class CurrencyMatrixGenerator
    {
        public static string[] GenerateCurrencyMatrix(string currency)
        {
            var order = new List<string> {"EUR", "GBP", "AUD", "NZD", "USD", "CAD", "CHF", "JPY"};
            var strength = order.IndexOf(currency);

            return order
                .Where(s => s != currency)
                .Select(s => order.IndexOf(s) < strength ? s + currency : currency + s)
                .ToArray();


            // return order.Take(order.IndexOf(currency)).Select(s => s + currency)
            //     .Concat(order.Skip(order.IndexOf(currency) + 1)
            //         .Select(s => currency + s)).ToArray();


            // var orderCurrency = new[] {"EUR", "GBP", "AUD", "NZD", "USD", "CAD", "CHF", "JPY"};
            // bool f = false;
            // List<string> result = new List<string>();
            // foreach (var s in orderCurrency)
            // {
            //     if (s == currency)
            //     {
            //         f = true;
            //         continue;
            //     }
            //
            //     if (f == false)
            //     {
            //         result.Add(s + currency);
            //     }
            //     else
            //     {
            //         result.Add(currency + s);
            //     }
            // }
            //
            // return result.ToArray();
        }
    }
}