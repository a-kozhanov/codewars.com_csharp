using System.IO;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class IsEvenBitwiseSeriesTests
    {
        // [Test]
        // public void IsEven_SourceCode_DoesNotContainModOperator()
        // {
        //     var text = File.ReadAllText("/workspace/solution.txt");
        //     Assert.IsFalse(text.Contains("%"));
        // }

        [TestCase(true, 2)]
        [TestCase(false, 3)]
        [TestCase(true, 14)]
        [TestCase(false, 15)]
        [TestCase(true, 26)]
        [TestCase(false, 27)]
        public void IsEven_CalledWithAnyInt_ReturnsCorrectResult(bool expected, int n)
        {
            var message = $"{n} is ";
            message += expected ? "even" : "odd";
            Assert.AreEqual(expected, IsEvenBitwiseSeries.IsEven(n), message);
        }
    }
}