using System.Linq;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class MaximumTripletSumArraySeries7Tests
    {
        [TestCase("-2 0 2", 0)]
        [TestCase("3 2 6 8 2 3", 17)]
        [TestCase("-2 -4 0 -9 2", 0)]
        [TestCase("-5 -1 -9 0 2", 1)]
        [TestCase("2 9 13 10 5 2 9 5", 32)]
        [TestCase("2 1 8 0 6 4 8 6 2 4", 18)]
        [TestCase("-3 -27 -4 -2 -27 -2", -9)]
        [TestCase("-7 12 -7 29 -5 0 -7 0 0 29", 41)]
        [TestCase("-14 -12 -7 -42 -809 -14 -12", -33)]
        [TestCase("-13 -50 57 13 67 -13 57 108 67", 232)]
        public void BasicTests(string s, int expected)
        {
            var a = s.Split().Select(int.Parse).ToArray();
            Assert.That(MaximumTripletSumArraySeries7.MaxTriSum(a), Is.EqualTo(expected));
        }
    }
}