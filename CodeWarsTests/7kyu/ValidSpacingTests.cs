using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class ValidSpacingTests
    {
        [Test(Description = "Sample tests")]
        public void SampleTests()
        {
            Test(true, "Hello world");
            Test(false, " Hello world");
            Test(false, "Hello world ");
            Test(true, "Hello");
            Test(true, "Helloworld");
        }

        private void Test(bool solution, string input)
        {
            Assert.AreEqual(solution, KataValidSpacing.ValidSpacing(input), $"Incorrect answer for input \"{input}\"");
        }
    }
}