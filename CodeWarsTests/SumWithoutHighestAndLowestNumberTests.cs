using System;
using System.Linq;
using NUnit.Framework;
using CodeWars;

namespace CodeWarsTests
{
    [TestFixture]
    public class SumWithoutHighestAndLowestNumberTests
    {
        [Test]
        public void BasicTest()
        {
            Assert.AreEqual(16, SumWithoutHighestAndLowestNumber.Sum(new[] { 6, 2, 1, 8, 10 }));
        }


        private Random rand = new Random((int)DateTime.Now.Ticks);

        [Test]
        public void SumOnlyOneElement()
        {
            Assert.AreEqual(0, SumWithoutHighestAndLowestNumber.Sum(new[] { 6 }));
        }

        [Test]
        public void SumOnlyTwoElements()
        {
            Assert.AreEqual(0, SumWithoutHighestAndLowestNumber.Sum(new[] { 6, 7 }));
        }

        [Test]
        public void SumPositives()
        {
            Assert.AreEqual(16, SumWithoutHighestAndLowestNumber.Sum(new[] { 6, 2, 1, 8, 10 }));
        }

        [Test]
        public void SumPositivesWithDoubleMax()
        {
            Assert.AreEqual(17, SumWithoutHighestAndLowestNumber.Sum(new[] { 6, 0, 1, 10, 10 }));
        }

        [Test]
        public void SumNegatives()
        {
            Assert.AreEqual(-28, SumWithoutHighestAndLowestNumber.Sum(new[] { -6, -20, -1, -10, -12 }));
        }

        [Test]
        public void SumMixed()
        {
            Assert.AreEqual(3, SumWithoutHighestAndLowestNumber.Sum(new[] { -6, 20, -1, 10, -12 }));
        }

        [Test]
        public void SumEmptyArray()
        {
            Assert.AreEqual(0, SumWithoutHighestAndLowestNumber.Sum(new int[0]));
        }

        [Test]
        public void SumNullArray()
        {
            Assert.AreEqual(0, SumWithoutHighestAndLowestNumber.Sum(null));
        }


        [Test]
        public void SumRandom()
        {
            int[] numbers = new int[6];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rand.Next(-500, 600);
            }

            Assert.AreEqual(numbers.Sum() - numbers.Min() - numbers.Max(), SumWithoutHighestAndLowestNumber.Sum(numbers));
        }

    }
}