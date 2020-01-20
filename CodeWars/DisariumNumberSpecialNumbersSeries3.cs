/*
https://www.codewars.com/kata/5a53a17bfd56cb9c14000003/train/csharp
https://www.codewars.com/kata/5a53a17bfd56cb9c14000003/solutions/csharp

7 kyu
Disarium Number (Special Numbers Series #3)

Definition
Disarium number is the number that The sum of its digits powered with their respective positions is equal to the number itself.

Task
Given a number, Find if it is Disarium or not .

Warm-up (Highly recommended)
Playing With Numbers Series
Notes
Number passed is always Positive .
Return the result as String
Input >> Output Examples
disariumNumber(89) ==> return "Disarium !!"
Explanation:
Since , 81 + 92 = 89 , thus output is "Disarium !!"
disariumNumber(564) ==> return "Not !!"
Explanation:
Since , 51 + 62 + 43 = 105 != 564 , thus output is "Not !!"

Playing with Numbers Series
Playing With Lists/Arrays Series
For More Enjoyable Katas
ALL translations are welcomed
Enjoy Learning !!
Zizou
*/

using System;
using System.Linq;

namespace CodeWars
{
    public class DisariumNumberSpecialNumbersSeries3
    {
        public static string DisariumNumber(int number)
        {
            return number.ToString().Select((c, i) => Math.Pow(int.Parse(c.ToString()), ++i)).Sum() == number
                ? "Disarium !!"
                : "Not !!";
        }


        // public static string DisariumNumber(int number)
        // {
        //     return number.ToString().Select((x,i) => Math.Pow(char.GetNumericValue(x), ++i)).Sum() == number ? "Disarium !!" : "Not !!";
        // }


        // public static string DisariumNumber(int number)
        // {
        //     var arrayNumbers = number.ToString().ToArray();
        //     double result = 0;
        //     for (int i = 0; i < arrayNumbers.Length; i++)
        //     {
        //         result += Math.Pow(arrayNumbers[i] - '0',i+1);
        //     }
        //     return result==number?"Disarium !!": "Not !!";
        // }


        // public static string DisariumNumber(int number)
        // {
        //     double sum = 0;
        //     var arr = number.ToString().Select(x => int.Parse(x.ToString())).ToArray();
        //     for(int i = 1; i <= arr.Length; i++)
        //         sum += Math.Pow(arr[i - 1],i);
        //     if(sum != number)
        //         return "Not !!";
        //     return "Disarium !!";
        // }


        // public static string DisariumNumber(int number)
        // {
        //     int n = 0; 
        //     string s = ""+number;
        //     for (int i = 0; i < s.Length; i++)
        //         n += (int)Math.Pow(s[i]-'0',i+1);
        //     return n == number ? "Disarium !!" : "Not !!";
        // }


        // public static string DisariumNumber(int number)
        // {
        //     return (number.ToString().Select((x, i) => Math.Pow(int.Parse(x.ToString()), i + 1)).Sum() == number) ? "Disarium !!" : "Not !!";
        // }


        // public static string DisariumNumber(int number)
        // {
        //     int pow = 1;
        //     double result = 0;
        //     foreach (var item in number.ToString().ToCharArray())
        //     {
        //         result += Math.Pow(double.Parse(item.ToString()), pow);
        //         pow++;
        //     }
        //
        //     if (result == number)
        //     {
        //         return "Disarium !!";
        //     }
        //
        //     return "Not !!"; 
        // }
    }
}