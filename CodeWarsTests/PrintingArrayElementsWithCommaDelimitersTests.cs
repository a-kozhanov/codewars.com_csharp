using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class PrintingArrayElementsWithCommaDelimitersTests
    {
        [Test]
        public void BasicTests()
        {
            var data = new object[] { 2, 4, 5, 2 };
            Assert.AreEqual("2,4,5,2", PrintingArrayElementsWithCommaDelimiters.PrintArray(data), "int test failed");
        }
    }
}