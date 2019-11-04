using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class MultiplyNumberTests
    {
        [Test, Description("Basic Tests")]
        public void SampleTest()
        {
            Assert.AreEqual(250, MultiplyNumber.Multiply(10));
            Assert.AreEqual(25, MultiplyNumber.Multiply(5));
            Assert.AreEqual(25000, MultiplyNumber.Multiply(200));
            Assert.AreEqual(0, MultiplyNumber.Multiply(0));
            Assert.AreEqual(-10, MultiplyNumber.Multiply(-2));
        }
    }
}