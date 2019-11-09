using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class FillingAnArrayPart1Tests
    {
        [Test, Description("Kata.Arr creates a new array with the numbers 0 to N-1")]
        public void ExampleTest()
        {
            Assert.IsTrue(FillingAnArrayPart1.Arr(0).GetType().IsArray, "FillingAnArrayPart1.Arr creates a new array with the numbers 0 to N-1");
            Assert.AreEqual(new int[0], FillingAnArrayPart1.Arr(0), "should return a blank array when called with no argument");
            Assert.AreEqual(new int[] { 0, 1, 2, 3 }, FillingAnArrayPart1.Arr(4), "should return 0 to 3 when called with 4");
        }
    }
}