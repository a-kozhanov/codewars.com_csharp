/*
https://www.codewars.com/kata/price-of-mangoes/train/csharp
https://www.codewars.com/kata/57a77726bb9944d000000b06/solutions/csharp

8 kyu
Price of Mangoes

There's a "3 for 2" (or "2+1" if you like) offer on mangoes. For a given quantity and price (per mango), calculate the total cost of the mangoes.

Examples
mango(3, 3) ==> 6    # 2 mangoes for 3 = 6; +1 mango for free
mango(9, 5) ==> 30   # 6 mangoes for 5 = 30; +3 mangoes for free
*/

namespace CodeWars
{
    public class PriceOfMangoes
    {
        public static int Mango(int quantity, int price)
        {
            return (quantity - quantity / 3) * price;
        }
    }
}