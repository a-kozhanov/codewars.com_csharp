using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class CalculateBMITests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual("Normal", CalculateBMI.Bmi(80, 1.80));
        }
    }
}