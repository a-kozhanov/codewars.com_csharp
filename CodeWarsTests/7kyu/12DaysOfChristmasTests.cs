using System;
using CodeWars;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace CodeWarsTests
{
    [TestFixture]
    public class _12DaysOfChristmasTests
    {
        // // Show
        // private string ForDisplay(List<string> lines) => string.Join("\n", lines.Select(x => $"\t{x}"));
        //
        // // Common testing code
        // private void DoTest(int verse, string[] linesOrig)
        // {
        //     Console.WriteLine("Verse " + verse);
        //     var lines = new List<string>(linesOrig);
        //     Shuffle(lines);
        //     Console.WriteLine("Jumbled:\n" + ForDisplay(lines));
        //     lines.Sort(new _12DaysOfChristmas());
        //     Console.WriteLine("Sorted:\n" + ForDisplay(lines));
        //     Assert.AreEqual(linesOrig, lines.ToArray());
        // }
        //
        // private static void Shuffle<T>(List<T> deck)
        // {
        //     var rnd = new Random();
        //     for (int n = deck.Count - 1; n > 0; --n)
        //     {
        //         int k = rnd.Next(n + 1);
        //         T temp = deck[n];
        //         deck[n] = deck[k];
        //         deck[k] = temp;
        //     }
        // }
        //
        // [Test]
        // public void Verse1()
        // {
        //     var linesOrig = new[]
        //     {
        //         "On the 1st day of Christmas my true love gave to me",
        //         "a partridge in a pear tree."
        //     };
        //     DoTest(1, linesOrig);
        // }
        //
        // [Test]
        // public void Verse2()
        // {
        //     var linesOrig = new[]
        //     {
        //         "On the 2nd day of Christmas my true love gave to me",
        //         "2 turtle doves and",
        //         "a partridge in a pear tree."
        //     };
        //     DoTest(2, linesOrig);
        // }
        //
        // [Test]
        // public void Verse3()
        // {
        //     var linesOrig = new[]
        //     {
        //         "On the 3rd day of Christmas my true love gave to me",
        //         "3 French hens,",
        //         "2 turtle doves and",
        //         "a partridge in a pear tree."
        //     };
        //     DoTest(3, linesOrig);
        // }
        //
        // [Test]
        // public void Verse4()
        // {
        //     var linesOrig = new[]
        //     {
        //         "On the 4th day of Christmas my true love gave to me",
        //         "4 calling birds,",
        //         "3 French hens,",
        //         "2 turtle doves and",
        //         "a partridge in a pear tree."
        //     };
        //     DoTest(4, linesOrig);
        // }
        //
        // [Test]
        // public void Verse5()
        // {
        //     var linesOrig = new[]
        //     {
        //         "On the 5th day of Christmas my true love gave to me",
        //         "5 golden rings,",
        //         "4 calling birds,",
        //         "3 French hens,",
        //         "2 turtle doves and",
        //         "a partridge in a pear tree."
        //     };
        //     DoTest(5, linesOrig);
        // }
        //
        // [Test]
        // public void Verse6()
        // {
        //     var linesOrig = new[]
        //     {
        //         "On the 6th day of Christmas my true love gave to me",
        //         "6 geese a laying,",
        //         "5 golden rings,",
        //         "4 calling birds,",
        //         "3 French hens,",
        //         "2 turtle doves and",
        //         "a partridge in a pear tree."
        //     };
        //     DoTest(6, linesOrig);
        // }
        //
        // [Test]
        // public void Verse7()
        // {
        //     var linesOrig = new[]
        //     {
        //         "On the 7th day of Christmas my true love gave to me",
        //         "7 swans a swimming,",
        //         "6 geese a laying,",
        //         "5 golden rings,",
        //         "4 calling birds,",
        //         "3 French hens,",
        //         "2 turtle doves and",
        //         "a partridge in a pear tree."
        //     };
        //     DoTest(7, linesOrig);
        // }
        //
        // [Test]
        // public void Verse8()
        // {
        //     var linesOrig = new[]
        //     {
        //         "On the 8th day of Christmas my true love gave to me",
        //         "8 maids a milking,",
        //         "7 swans a swimming,",
        //         "6 geese a laying,",
        //         "5 golden rings,",
        //         "4 calling birds,",
        //         "3 French hens,",
        //         "2 turtle doves and",
        //         "a partridge in a pear tree."
        //     };
        //     DoTest(8, linesOrig);
        // }
        //
        // [Test]
        // public void Verse9()
        // {
        //     var linesOrig = new[]
        //     {
        //         "On the 9th day of Christmas my true love gave to me",
        //         "9 ladies dancing,",
        //         "8 maids a milking,",
        //         "7 swans a swimming,",
        //         "6 geese a laying,",
        //         "5 golden rings,",
        //         "4 calling birds,",
        //         "3 French hens,",
        //         "2 turtle doves and",
        //         "a partridge in a pear tree."
        //     };
        //     DoTest(9, linesOrig);
        // }
        //
        // [Test]
        // public void Verse10()
        // {
        //     var linesOrig = new[]
        //     {
        //         "On the 10th day of Christmas my true love gave to me",
        //         "10 lords a leaping,",
        //         "9 ladies dancing,",
        //         "8 maids a milking,",
        //         "7 swans a swimming,",
        //         "6 geese a laying,",
        //         "5 golden rings,",
        //         "4 calling birds,",
        //         "3 French hens,",
        //         "2 turtle doves and",
        //         "a partridge in a pear tree."
        //     };
        //     DoTest(10, linesOrig);
        // }
        //
        // [Test]
        // public void Verse11()
        // {
        //     var linesOrig = new[]
        //     {
        //         "On the 11th day of Christmas my true love gave to me",
        //         "11 pipers piping,",
        //         "10 lords a leaping,",
        //         "9 ladies dancing,",
        //         "8 maids a milking,",
        //         "7 swans a swimming,",
        //         "6 geese a laying,",
        //         "5 golden rings,",
        //         "4 calling birds,",
        //         "3 French hens,",
        //         "2 turtle doves and",
        //         "a partridge in a pear tree."
        //     };
        //     DoTest(11, linesOrig);
        // }
        //
        // [Test]
        // public void Verse12()
        // {
        //     var linesOrig = new[]
        //     {
        //         "On the 12th day of Christmas my true love gave to me",
        //         "12 drummers drumming,",
        //         "11 pipers piping,",
        //         "10 lords a leaping,",
        //         "9 ladies dancing,",
        //         "8 maids a milking,",
        //         "7 swans a swimming,",
        //         "6 geese a laying,",
        //         "5 golden rings,",
        //         "4 calling birds,",
        //         "3 French hens,",
        //         "2 turtle doves and",
        //         "a partridge in a pear tree."
        //     };
        //     DoTest(12, linesOrig);
        // }
    }
}