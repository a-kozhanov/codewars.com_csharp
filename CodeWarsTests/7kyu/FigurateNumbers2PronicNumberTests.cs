using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class FigurateNumbers2PronicNumberTests
    {
        [Test]
        public static void FixedTest()
        {
            Assert.AreEqual(true, FigurateNumbers2PronicNumber.IsPronic(0));
            Assert.AreEqual(false, FigurateNumbers2PronicNumber.IsPronic(1));
            Assert.AreEqual(true, FigurateNumbers2PronicNumber.IsPronic(2));
            Assert.AreEqual(false, FigurateNumbers2PronicNumber.IsPronic(3));
            Assert.AreEqual(false, FigurateNumbers2PronicNumber.IsPronic(4));
            Assert.AreEqual(false, FigurateNumbers2PronicNumber.IsPronic(5));
            Assert.AreEqual(true, FigurateNumbers2PronicNumber.IsPronic(6));
            Assert.AreEqual(false, FigurateNumbers2PronicNumber.IsPronic(-3));
            Assert.AreEqual(false, FigurateNumbers2PronicNumber.IsPronic(-27));
        }
    }
}