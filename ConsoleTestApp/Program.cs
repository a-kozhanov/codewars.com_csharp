using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text.RegularExpressions;
using CodeWars;

namespace ConsoleTestApp
{
    class Program
    {
        //public static int ToNumeral(BitArray binary)
        //{
        //    if (binary == null)
        //        throw new ArgumentNullException("binary");
        //    if (binary.Length > 32)
        //        throw new ArgumentException("must be at most 32 bits long");

        //    var result = new int[1];
        //    binary.CopyTo(result, 0);
        //    return result[0];
        //}

        //public static ulong BitArrayToU64(BitArray ba)
        //{
        //    var len = Math.Min(64, ba.Count);
        //    ulong n = 0;
        //    for (int i = 0; i < len; i++)
        //    {
        //        if (ba.Get(i))
        //            n |= 1UL << i;
        //    }
        //    return n;
        //}

        //public static string ToBinary(int numeral)
        //{
        //    return new BitArray(new[] { numeral }).ToString();
        //}

        static void Main(string[] args)
        {
            //Console.WriteLine(new string("world".Reverse().ToArray()));
            //Console.WriteLine(ReversedStrings.Solution("world"));

            //Console.WriteLine(SumWithoutHighestAndLowestNumber.Sum(new[] { 1, 1, 11, 2, 3 })); //6
            //Console.WriteLine(SumWithoutHighestAndLowestNumber.Sum(new[] { 6, 2, 1, 8, 10 })); //16
            //Console.WriteLine(SumWithoutHighestAndLowestNumber.Sum(new[] { 1, 2, 3 })); 
            //Console.WriteLine(SumWithoutHighestAndLowestNumber.Sum(new[] { 1, 2})); 
            //Console.WriteLine(SumWithoutHighestAndLowestNumber.Sum(new[] { 3 }));
            //Console.WriteLine(SumWithoutHighestAndLowestNumber.Sum(null));

            //Console.WriteLine(TitleCase.titleCase("a an the of", "a clash of KINGS"));    //"A Clash of Kings"
            //Console.WriteLine(TitleCase.titleCase("The In", "THE WIND IN THE WILLOWS"));  //"The Wind in the Willows"
            //Console.WriteLine(TitleCase.titleCase("the quick brown fox"));                         //"The Quick Brown Fox"


            //Console.WriteLine(BreakCamelCase.breakCamelCase("c a m e l CamelCasing"));
            //Console.WriteLine(BreakCamelCase.breakCamelCase("camelCasingTest"));
            //Console.WriteLine(BreakCamelCase.breakCamelCase("...Sm Xjbjr Jiw Sijuop Q Xcwt Pcy Bwowulhs Feyz Bx L N Pqjsghc J"));

            //Console.WriteLine(Divisors.divisors(30));

            //MexicanWave mexicanWave = new MexicanWave();
            //Console.WriteLine(mexicanWave.wave("hello"));
            //Console.WriteLine(mexicanWave.wave("two words"));
            //foreach (var w in mexicanWave.wave("two words"))
            //{
            //    Console.WriteLine(w);
            //}

            //Console.WriteLine(ShortestWord.FindShort("turns out random test cases are easier than writing out basic ones"));


            //var fighters = new string[][]
            //{
            //    new string[] { "Ryu", "E.Honda", "Blanka", "Guile", "Balrog", "Vega" },
            //    new string[] { "Ken", "Chun Li", "Zangief", "Dhalsim", "Sagat", "M.Bison" },
            //};

            //var moves = new string[] { "up", "left", "right", "left", "left" };
            //StreetFighter2 sf = new StreetFighter2();
            //Console.WriteLine(sf.StreetFighterSelection(fighters, new int[] { 0, 0 }, moves));

            //CountCharacters.Count("aba");

            //Console.WriteLine(MovesSquaredStrings.Oper(MovesSquaredStrings.VertMirror, "abcd\nefgh\nijkl\nmnop"));
            //Console.WriteLine();
            //WriteLine(MovesSquaredStrings.Oper(MovesSquaredStrings.HorMirror, "abcd\nefgh\nijkl\nmnop"));

            //Regex r = new Regex(@"^(\1.|^.)+$");
            ////n(n+1)/2

            //for (int n = 1; n <= 50; n++)
            //{
            //    Console.Write("{0} ", n * (n + 1) / 2);

            //    //if (r.IsMatch("".PadLeft(n)))
            //    //{
            //    //    Console.Write("({0}) ", n);
            //    //}
            //}

            //Console.WriteLine(SumTriangularNumbers.sumTriangularNumbers(6));


            //for (int i = 2; i <= 2; i += 2)
            //{
            //    Console.WriteLine(i);
            //}

            //return;

            // IEnumerable<int> squares = Enumerable.Range(2, 2).Select(x => x + x);

            // Console.WriteLine(string.Join(", ", squares));

            //foreach (int num in squares)
            //{
            //    Console.WriteLine(num);
            //}


            //sequenceSum(2,6,2) === 12 // 2 + 4 + 6
            //int start, int end, int step
            //int start = 2;
            //int stop = 6;
            //int step = 2;
            ////int x = start;

            //var numbers = new List<int>();
            //for (var i = start; i <= stop; i += step) numbers.Add(i);
            //Console.WriteLine(numbers.Sum());

            //Console.WriteLine(string.Join(", ", Enumerable.Range(start, ((stop - start) / step) + ((stop - start) % step == 0 ? 0 : 1))));

            //Console.WriteLine(string.Join(", ", RangeIterator(start, stop, step)));
            //Console.WriteLine(RangeIterator(start, stop, step).Sum());


            //Console.WriteLine(RemoveAnchorURL.RemoveUrlAnchor("www.codewars.com#about"));
            //Console.WriteLine(YourOrder.Order("is2 Thi1s T4est 3a"));


            //Console.WriteLine(IntegersRecreationOne.listSquared(1, 250));

            //Console.WriteLine(DescendingOrder.descendingOrder(2110));
            //Console.WriteLine(DescendingOrder.descendingOrder(1201));

            //Console.WriteLine(RemoveFirstLastCharacter.Remove_char("qwerty"));
            //Console.WriteLine(CountDigit.NbDig(10, 1));
            //Console.WriteLine(CountDigit.NbDig(10, 1));
            //            Console.WriteLine(CountDigit.NbDig(25, 1));
            //Console.WriteLine(CountDigit.NbDig(25, 1));
            //1, 4, 9, 10, 11, 12, 13, 14, 19, 21 в квадрате: 1, 16, 81, 100, 121, 144, 169, 196, 361, 441

            //Console.WriteLine(SquareEveryDigit.SquareDigits(9119)); //811181
            //Console.WriteLine(RegexValidatePIN.ValidatePin("9¾9¾"));

            //Console.WriteLine(CountingDuplicates.DuplicateCount("Indivisibility"));

            //Console.WriteLine(CreditCardMask.Maskify("4556364607935616"));

            //Console.WriteLine(SumAllMultiples.findSum(5));

            //float input = 25;
            ////byte[] buffer = BitConverter.GetBytes(input);
            ////1, 1, 1, 1
            //byte[] buffer = new byte[] { 0, 0, 1, 0 };
            //Console.WriteLine(string.Concat(buffer));
            //var output = BitConverter.ToInt32(buffer, 0);
            //Console.WriteLine(output);

            ////Console.WriteLine(ToNumeral(new BitArray(new[] { 1, 1, 1, 1 })));
            //Console.WriteLine(BitArrayToU64(new BitArray(new[] { 1, 1, 1, 1, 1, 1, 1 })));



            //var bits1 = new BitVector32();
            //int bit1 = BitVector32.CreateMask();
            //int bit2 = BitVector32.CreateMask(bit1);
            //int bit3 = BitVector32.CreateMask(bit2);
            //int bit4 = BitVector32.CreateMask(bit3);
            ////int bit5 = BitVector32.CreateMask(bit4);
            //bits1[bit1] = true;
            //bits1[bit2] = true;
            //bits1[bit3] = false;
            //bits1[bit4] = false;
            ////bits1[bit5] = true;
            //Console.WriteLine(bits1);



            //int[] Test1 = new int[] { 0, 0, 1, 0 };
            //BitArray myBitArr = new BitArray(4);

            //myBitArr[0] = Convert.ToBoolean(Test1[3]);
            //myBitArr[1] = Convert.ToBoolean(Test1[2]);
            //myBitArr[2] = Convert.ToBoolean(Test1[1]);
            //myBitArr[3] = Convert.ToBoolean(Test1[0]);

            ////foreach (Object obj in myBitArr)
            ////{
            ////    Console.WriteLine(obj);
            ////}

            //var result = new int[1];
            //myBitArr.CopyTo(result, 0);

            //Console.WriteLine(result[0]);
            //new object[] { "Hello", "Goodbye", "Hello Again" }
            //Console.WriteLine();
            //RemovingElements.RemoveEveryOther(new object[] { "Hello", "Goodbye", "Hello Again" });
            //RemovingElements.RemoveEveryOther(new object[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
            //Assert.AreEqual(new object[] { 1, 3, 5, 7, 9 }, RemovingElements.RemoveEveryOther(new object[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }));

            //RemovingElements.RemoveEveryOther(new object[] { "Hello", "Goodbye", "Hello Again" });
            //RemovingElements.RemoveEveryOther(new object[] { new object[] { 1, 2 } });
            //RemovingElements.RemoveEveryOther(new object[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
            //RemovingElements.RemoveEveryOther(new object[] { new object[] { "Goodbye" }, new Dictionary<string, string>() { { "Great", "Job" } } });
            //RemovingElements.RemoveEveryOther(new object[] { });

            //GiveMeDiamond.print(5);

            //[TestCase(63, 7, true)]
            Console.WriteLine(GrasshopperCheckForFactor.CheckForFactor(63, 7));

        }




    }
}
