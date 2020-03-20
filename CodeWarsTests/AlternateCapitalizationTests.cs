using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class AlternateCapitalizationTests
    {
        [Test]
        public void MyTest()
        {
            Assert.AreEqual(new string[2] {"AbCdEf", "aBcDeF"}, AlternateCapitalization.Capitalize("abcdef"));
            Assert.AreEqual(new string[2] {"CoDeWaRs", "cOdEwArS"}, AlternateCapitalization.Capitalize("codewars"));
            Assert.AreEqual(new string[2] {"AbRaCaDaBrA", "aBrAcAdAbRa"},
                AlternateCapitalization.Capitalize("abracadabra"));
            Assert.AreEqual(new string[2] {"CoDeWaRrIoRs", "cOdEwArRiOrS"},
                AlternateCapitalization.Capitalize("codewarriors"));
        }
    }
}