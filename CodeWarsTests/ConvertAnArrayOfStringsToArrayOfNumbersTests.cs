using System;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class ConvertAnArrayOfStringsToArrayOfNumbersTests
    {
        [Test]
        public void ExampleTest()
        {
            Console.WriteLine("Running ToDoubleArray(\"1.1\",\"2.2\",\"3.3\")...");

            Assert.AreEqual(new double[] {1.1, 2.2, 3.3},
                ConvertAnArrayOfStringsToArrayOfNumbers.ToDoubleArray(new string[] {"1.1", "2.2", "3.3"}));
        }
    }
}