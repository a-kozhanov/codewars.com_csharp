using System;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class IsItNumberTests
    {
        // [Test, Sequential]
        // public void BasicTests(
        //     [Values("s2324", "3 4", "3-4", "3  4   ", "34.65", "-0", " ", "", "0.0", "ab", "ab  cd")]
        //     string input,
        //     [Values(false, false, false, false, true, true, false, false, true, false, false, false)]
        //     bool expectedResult)
        // {
        //     Assert.IsTrue(IsItNumber.IsDigit(input) == expectedResult);
        // }
        //
        // [Test]
        // public void RandomTest()
        // {
        //     var random = new Random();
        //
        //     for (var i = 0; i < 100; i++)
        //     {
        //         var a = $"{random.NextDouble()}";
        //         var b = $"{random.NextDouble()}";
        //         var c = $"{random.NextDouble()}";
        //         var d = "fsda243fs";
        //
        //         Assert.IsTrue(IsItNumber.IsDigit(a));
        //         Assert.IsTrue(IsItNumber.IsDigit(b));
        //         Assert.IsTrue(IsItNumber.IsDigit(c));
        //         Assert.IsFalse(IsItNumber.IsDigit(d));
        //     }
        // }
    }
}