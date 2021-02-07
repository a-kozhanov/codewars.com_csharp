/*
https://www.codewars.com/kata/5966f6343c0702d1dc00004c/csharp

7 kyu
You Got Change?

Create a function that will take any amount of money and break it down to the smallest number of bills as possible. 
Only integer amounts will be input, NO floats. 
This function should output an array, where each element in the array represents the amount of a certain bill type. 
The array will be set up in this manner:

array[0] ---> represents $1 bills

array[1] ---> represents $5 bills

array[2] ---> represents $10 bills

array[3] ---> represents $20 bills

array[4] ---> represents $50 bills

array[5] ---> represents $100 bills

In the case below, we broke up $365 into 1 $5 bill, 1 $10 bill, 1 $50 bill, and 3 $100 bills.

  giveChange(365) // =>  [0,1,1,0,1,3]
In this next case, we broke $217 into 2 $1 bills, 1 $5 bill, 1 $10 bill, and 2 $100 bills.

  giveChange(217) // => [2,1,1,0,0,2]
*/

namespace CodeWars
{
    public class YouGotChange
    {
        public static int[] GiveChange(int amount)
        {
            return new[]
            {
                amount % 5,
                amount % 10 / 5,
                amount % 50 % 20 / 10,
                amount % 50 / 20,
                amount % 100 / 50,
                amount / 100
            };


            // return new[]
            // {
            //     amount % 100 % 50 % 20 % 10 % 5 / 1,
            //     amount % 100 % 50 % 20 % 10 / 5,
            //     amount % 100 % 50 % 20 / 10,
            //     amount % 100 % 50 / 20,
            //     amount % 100 / 50,
            //     amount / 100
            // };


            // var arr = new[] {1, 5, 10, 20, 50, 100};
            // var result = new int[6];
            // var index = 5;
            //
            // while (amount > 0)
            // {
            //     result[index] = amount / arr[index];
            //     amount -= arr[index] * result[index];
            //     index--;
            // }
            // return result;


            // int[] result = new int[6];
            // result[5] = amount / 100;
            // amount -= 100 * (amount / 100);
            // result[4] = amount / 50;
            // amount -= 50 * (amount / 50);
            // result[3] = amount / 20;
            // amount -= 20 * (amount / 20);
            // result[2] = amount / 10;
            // amount -= 10 * (amount / 10);
            // result[1] = amount / 5;
            // amount -= 5 * (amount / 5);
            // result[0] = amount;
            // return result;


            // int hundred = amount / 100;
            // amount %= 100;
            // int fifty = amount / 50;
            // amount %= 50;
            // int twenty = amount / 20;
            // amount %= 20;
            // int ten = amount / 10;
            // amount %= 10;
            // int five = amount / 5;
            // amount %= 5;
            // int one = amount % 5;
            // return new[] {one, five, ten, twenty, fifty, hundred};
        }
    }
}