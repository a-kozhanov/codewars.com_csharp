/*
https://www.codewars.com/kata/5805ed25c2799821cb000005/csharp

7 kyu
Birthday I - Cake

It's your Birthday. Your colleagues buy you a cake. The numbers of candles on the cake is provided (x). 
Please note this is not reality, and your age can be anywhere up to 1,000. Yes, you would look a mess.

As a surprise, your colleagues have arranged for your friend to hide inside the cake and burst out. T
hey pretend this is for your benefit, but likely it is just because they want to see you fall over covered in cake. 
Sounds fun!

When your friend jumps out of the cake, he/she will knock some of the candles to the floor. 
If the number of candles that fall is higher than 70% of total candles (x), the carpet will catch fire.

You will work out the number of candles that will fall from the provided string (y). 
You must add up the character ASCII code of each even indexed (assume a 0 based indexing) character in y, 
with the alphabetical position of each odd indexed character in y to give the string a total.

example: 'abc' --> a=97, b=2, c=99 --> y total = 198.

If the carpet catches fire, return 'Fire!', if not, return 'That was close!'.
*/

using System.Linq;

namespace CodeWars
{
    public class BirthdayICake
    {
        public static string Cake(int x, string y)
        {
            //return y.Select((a, i) => new {a, i}).Sum(_ => _.i % 2 == 0 ? _.a : _.a - 'a' + 1) > x * .7 ? "Fire!" : "That was close!";
            //return y.Select((n, i) => i % 2 == 0 ? (int) n : (int) n - 96).Sum() / (double) x > 0.7 ? "Fire!" : "That was close!";
            //return y.Select((z, i) => i % 2 == 0 ? (int) z : (int) z - 96).Sum() > 70 * x / 100 ? "Fire!" : "That was close!";
            //return y.Select((c, i) => i % 2 == 0 ? c : c - 96).Sum() >= (x * .7) ? "Fire!" : "That was close!";
            //return y.Select((t, i) => i % 2 == 0 ? t : t - 96).Sum() > x * 0.7 ? "Fire!" : "That was close!";
            //return y.Select((c, i) => i % 2 == 0 ? c : c % 32).Sum() > 0.7 * x ? "Fire!" : "That was close!";
            //return y.Select(c => (int) c).Sum() - y.Length / 2 * 96 > x * 0.7 ? "Fire!" : "That was close!";
            //return (y.Sum(c => c) - (y.Length / 2 * 96)) / (double) x >= 0.7 ? "Fire!" : "That was close!";

            return y.Select((c, i) => i % 2 == 0 ? c : c % 32).Sum() > x * .7 ? "Fire!" : "That was close!";
        }
    }
}