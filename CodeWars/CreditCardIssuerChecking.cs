/*
https://www.codewars.com/kata/5701e43f86306a615c001868/csharp

7 kyu
Credit card issuer checking

Given a credit card number we can determine who the issuer/vendor is with a few basic knowns.

Complete the function getIssuer() that will use the values shown below to determine the card issuer for a given card number. 
If the number cannot be matched then the function should return the string Unknown.

| Card Type  | Begins With          | Number Length |
|------------|----------------------|---------------|
| AMEX       | 34 or 37             | 15            |
| Discover   | 6011                 | 16            |
| Mastercard | 51, 52, 53, 54 or 55 | 16            |
| VISA       | 4                    | 13 or 16      |

Examples
getIssuer(4111111111111111) == "VISA"
getIssuer(4111111111111) == "VISA"
getIssuer(4012888888881881) == "VISA"
getIssuer(378282246310005) == "AMEX"
getIssuer(6011111111111117) == "Discover"
getIssuer(5105105105105100) == "Mastercard"
getIssuer(5105105105105106) == "Mastercard"
getIssuer(9111111111111111) == "Unknown"
*/

using System.Text.RegularExpressions;

namespace CodeWars
{
    public class CreditCardIssuerChecking
    {
        public static string getIssuer(long number)
        {
            var card = number.ToString();
            if (Regex.IsMatch(card, "^3[47][0-9]{13}$")) return "AMEX";
            if (Regex.IsMatch(card, "^6011[0-9]{12}$")) return "Discover";
            if (Regex.IsMatch(card, "^5[1-5][0-9]{14}$")) return "Mastercard";
            if (Regex.IsMatch(card, "^4([0-9]{12}|[0-9]{15})$")) return "VISA";
            return "Unknown";
        }
    }
}