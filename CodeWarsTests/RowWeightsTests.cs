using System.Linq;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class KataRowWeightsTests
    {
        [TestCase("0", "0 0")]
        [TestCase("80", "80 0")]
        [TestCase("0 1 0", "0 1")]
        [TestCase("100 50", "100 50")]
        [TestCase("13 27 49", "62 27")]
        [TestCase("50 60 70 80", "120 140")]
        [TestCase("70 58 75 34 91", "236 92")]
        [TestCase("100 51 50 100", "150 151")]
        [TestCase("29 83 67 53 19 28 96", "211 164")]
        [TestCase("39 84 74 18 59 72 35 61", "207 235")]
        public void BasicTests(string s, string ex)
        {
            var a = s.Split().Select(int.Parse).ToArray();
            var expected = ex.Split().Select(int.Parse).ToArray();
            Assert.That(KataRowWeights.RowWeights(a), Is.EqualTo(expected));
        }
    }
}