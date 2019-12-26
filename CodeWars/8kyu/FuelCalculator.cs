/*
https://www.codewars.com/kata/fuel-calculator/train/csharp
https://www.codewars.com/kata/57b58827d2a31c57720012e8/solutions/csharp

8 kyu
Fuel Calculator

In this kata you will have to write a function that takes litres and pricePerLiter as arguments. 
Purchases of 2 or more litres get a discount of 5 cents per litre, 
purchases of 4 or more litres get a discount of 10 cents per litre, and so on every two litres, 
up to a maximum discount of 25 cents per litre. But total discount per liter cannot be more than 25 cents. 
round answer to 2 decimal places. Also you can guess that there will not be negative or non-numeric inputs.

Good Luck!
*/

using System;

namespace CodeWars
{
    public class FuelCalculator
    {
        public static double FuelPrice(double litres, double pricePerLiter)
        {
            var discount = pricePerLiter;
            
            for (var i = 2; i <= 10; i += 2)
            {
                if (litres >= i) discount -= 0.05;           
            }

            return Math.Round(litres * discount, 2);
        }
    }
}

// public static double FuelPrice(double l, double p) => Math.Round(l * (p - Math.Min(0.25, 0.05 * Math.Floor(l / 2))), 2);
//
// public static double FuelPrice(double litres, double pricePerLiter)
// {
// double disc = (int)litres / 2 * 0.05;
//     if(disc > 0.25) disc = 0.25;
//     
//     return System.Math.Round(litres * (pricePerLiter - disc), 2);
// }
//
//
// public static double FuelPrice(double litres, double pricePerLiter)
// {
// double totalDiscontPerLiter = Math.Truncate(litres / 2) * 0.05;
//     if(totalDiscontPerLiter > 0.25) totalDiscontPerLiter = 0.25;
//     return Math.Round(litres * (pricePerLiter - totalDiscontPerLiter),2);
// }


