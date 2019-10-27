
//https://www.codewars.com/kata/counting-change-combinations/train/csharp
//https://www.codewars.com/kata/541af676b589989aed0009e7/solutions/csharp

//Counting Change Combinations

//Write a function that counts how many different ways you can make change for an amount of money, given an array of coin denominations. For example, there are 3 ways to give change for 4 if you have coins with denomination 1 and 2:
//1+1+1+1, 1+1+2, 2+2.
//The order of coins does not matter:
//1+1+2 == 2+1+1
//Also, assume that you have an infinite amount of coins.
//Your function should take an amount to change and an array of unique denominations for the coins:
//CountCombinations(4, new[] {1,2}) // => 3
//CountCombinations(10, new[] {5,2,3}) // => 4
//CountCombinations(11, new[] {5,7}) //  => 0

using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class CountingChangeCombinations
    {
        public static int CountCombinations(int money, int[] coins)
        {
            var a = new int[money + 1];
            var b = new int[money + 1];
            a[0] = 1;

            foreach (var t in coins)
            {
                for (var j = 0; j <= money; j++)
                    for (var k = 0; j + k <= money; k += t)
                        b[j + k] += a[j];

                for (var j = 0; j <= money; j++)
                {
                    a[j] = b[j];
                    b[j] = 0;
                }
            }

            return a[money];
        }


        //public static int CountCombinations(int money, int[] coins)
        //{
        //    int[] ways = new int[money + 1];
        //    ways[0] = 1;

        //    for (int i = 0; i < coins.Length; i++)
        //    {
        //        for (int j = coins[i]; j <= money; j++)
        //        {
        //            ways[j] += ways[j - coins[i]];
        //        }
        //    }
        //    return ways[money];
        //}


        //public static int CountCombinations(int money, int[] coins)
        //{
        //    return (money < 0 || !coins.Any()) ? 0 : (money == 0) ? 1 : CountCombinations(money - coins[0], coins) + CountCombinations(money, coins.Skip(1).ToArray());
        //}


        //public static class Kata
        //{
        //    public static int CountCombinations(int money, int[] coins)
        //    {
        //        return Changes(money, ref coins, coins.Length);
        //    }

        //    private static int Changes(int money, ref int[] coins, int count)
        //    {
        //        if(count < 1 || money < 0) return 0;
        //        if(money == 0) return 1;
        //        return Changes(money, ref coins, count - 1) + Changes(money - coins[count- 1], ref coins, count);
        //    }
        //}


        //public static int CountCombinations(int m, int[] c)
        //    =>  m == 0 ? 1 : (c=c.Where(e=> e<=m).ToArray()).Select((e,i)=> CountCombinations(m-e, c.Skip(i).ToArray())).Sum();


        //public static int CountCombinations(int money, int[] coins)
        //{
        //    if (coins.Length == 0 || money == 0) {
        //        return 0;
        //    }

        //    var combinations = 0;
        //    var firstCoin = coins[0];
        //    var withoutFirst = coins.Skip(1).ToArray();

        //    if (money % firstCoin == 0) {
        //        combinations += 1;
        //    }

        //    for (var i = 0; i <= money / firstCoin; i++) {
        //        combinations += CountCombinations((money - (firstCoin*i)), withoutFirst);
        //    }

        //    return combinations;
        //}


        //public static int CountCombinations(int money, int[] coins)
        //{
        //    if (money < 0) return 0;
        //    if (money == 0) return 1;
        //    return coins.Select((t, i) => CountCombinations(money - t, coins.Take(i + 1).ToArray())).Sum();
        //}


        //public static int CountCombinations(int money, int[] coins)
        //{
        //    int combos = 0;
        //    for (int i = 0; i < coins.Length; i++) {
        //        if (money == coins[i]) combos += 1;
        //        else if (money > coins[i]) combos += CountCombinations(money - coins[i], coins.Skip(i).ToArray() ); 
        //    }
        //    return combos;
        //}


        //public static int CountCombinations(int money, int[] coins, int i = 0)
        //{
        //    if (money < 0) 
        //        return 0;
        //    if (money == 0) 
        //        return 1;
        //    if (coins.Length == i && money > 0)
        //        return 0;

        //    return CountCombinations(money - coins[i], coins, i) + CountCombinations(money, coins, i + 1);
        //}



        //public static int CountCombinations(int money, int[] coins)
        //{
        //    int Combinations(int remaining, int coinIndex)
        //    {
        //        if (remaining < 0 || coinIndex < 0) return 0;
        //        if (remaining == 0) return 1;
        //        return Combinations(remaining, coinIndex - 1) + Combinations(remaining - coins[coinIndex], coinIndex);
        //    }

        //    return Combinations(money, coins.Length - 1);
        //}



        //public static int CountCombinations(int money, int[] coins)
        //{
        //    int[] comb = new int[money + 1];
        //    comb[0] = 1;
        //    foreach (int coin in coins)
        //    {
        //        for (int i = 1; i < comb.Length; i++)
        //        {
        //            if (i >= coin) comb[i] += comb[i - coin];
        //        }
        //    }
        //    return comb[money];

        //}


        //public static int CountCombinations(int money, int[] coins, int i = 0)
        //{
        //    if (money < 0) return 0;
        //    if (money == 0) return 1;

        //    if (i == coins.Length && money > 0) {
        //        return 0;
        //    }

        //    return CountCombinations(money - coins[i], coins, i) + CountCombinations(money, coins, i + 1);

        //}


        //public static int CountCombinations(int money, int[] coins, int num = 0)
        //{
        //    if (money == 0)
        //        return 1;
        //    int res = 0;
        //    for (int i = num; i < coins.Length; i++)
        //    {
        //        if (money >= coins[i])
        //        {
        //            res += CountCombinations(money - coins[i], coins, i);
        //        }
        //    }
        //    return res;
        //}




    }
}