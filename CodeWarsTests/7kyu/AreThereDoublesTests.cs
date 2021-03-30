using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class AreThereDoublesTests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(false, AreThereDoubles.Double_check("abca"));
            Assert.AreEqual(true, AreThereDoubles.Double_check("aabc"));
            Assert.AreEqual(true, AreThereDoubles.Double_check("a 11 c d"));
            Assert.AreEqual(true, AreThereDoubles.Double_check("AabBcC"));
            Assert.AreEqual(true, AreThereDoubles.Double_check("a b  c"));
            Assert.AreEqual(false, AreThereDoubles.Double_check("a b c d e f g h i h k"));
            Assert.AreEqual(false, AreThereDoubles.Double_check("2020"));
            Assert.AreEqual(false, AreThereDoubles.Double_check("a!@€£#$%^&*()_-+=}]{[|\':;?/>.<,~"));
        }
    }
}