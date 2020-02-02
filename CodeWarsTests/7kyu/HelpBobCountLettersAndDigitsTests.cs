using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class HelpBobCountLettersAndDigitsTests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(7, HelpBobCountLettersAndDigits.CountLettersAndDigits("n!!ice!!123"));
        }
    }
}