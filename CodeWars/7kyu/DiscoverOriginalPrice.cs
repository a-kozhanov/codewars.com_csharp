/*
https://www.codewars.com/kata/552564a82142d701f5001228/csharp

7 kyu
Discover The Original Price

We need to write some code to return the original price of a product, t
he return type must be of type decimal and the number must be rounded to two decimal places.

We will be given the sale price (discounted price), and the sale percentage, 
our job is to figure out the original price.

For example:
Given an item at $75 sale price after applying a 25% discount, 
the function should return the original price of that item before applying the sale percentage, 
which is ($100.00) of course, rounded to two decimal places.

DiscoverOriginalPrice(75, 25) => 100.00M where 75 is the sale price (discounted price), 
25 is the sale percentage and 100 is the original price
*/

using System;

namespace CodeWars
{
    public class KataDiscoverOriginalPrice
    {
        public static decimal DiscoverOriginalPrice(decimal discountedPrice, decimal salePercentage)
        {
            //return decimal.Round(discountedPrice * 100 / (100 - salePercentage), 2);
            //return Math.Round(100 * discountedPrice / (100 - salePercentage), 2);
            return Math.Round(discountedPrice / (1 - salePercentage / 100), 2);
        }
    }
}