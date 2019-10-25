using System.Linq;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SwapValuesTests
    {
        [Test]
        public void ExampleTest()
        {
            int[] args = new[] { 1, 2 };

            KataSwapValues swapper = new KataSwapValues(args.Cast<object>().ToArray());
            swapper.SwapValues();

            Assert.AreEqual(2, swapper.Arguments[0], "Failed swapping numbers");
            Assert.AreEqual(1, swapper.Arguments[1], "Failed swapping numbers");
        }
    }
}