using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class BobsShortFormsTests
    {
        [Test]
        public void TestCase()
        {
            var kata = new BobsShortForms();

            //Should return word without vowels
            Assert.AreEqual("typhd", kata.ShortForm("typhoid"));
            Assert.AreEqual("fre", kata.ShortForm("fire"));
            Assert.AreEqual("dstry", kata.ShortForm("destroy"));
            Assert.AreEqual("kta", kata.ShortForm("kata"));
            Assert.AreEqual("cdwrs", kata.ShortForm("codewars"));

            //Should ignore vowels at beginning or end of word
            Assert.AreEqual("assrt", kata.ShortForm("assert"));
            Assert.AreEqual("insne", kata.ShortForm("insane"));
            Assert.AreEqual("nce", kata.ShortForm("nice"));
            Assert.AreEqual("amzng", kata.ShortForm("amazing"));
            Assert.AreEqual("incrrgble", kata.ShortForm("incorrigible"));

            //Should be case-insenstive
            Assert.AreEqual("HllO", kata.ShortForm("HeEllO"));
            Assert.AreEqual("inCRdBLE", kata.ShortForm("inCRediBLE"));
            Assert.AreEqual("IMpsSblE", kata.ShortForm("IMpOsSiblE"));
            Assert.AreEqual("UnnTNtNl", kata.ShortForm("UnInTENtiONAl"));
            Assert.AreEqual("AWSme", kata.ShortForm("AWESOme"));

            //Should support input with no vowels
            Assert.AreEqual("rhythm", kata.ShortForm("rhythm"));
            Assert.AreEqual("hymn", kata.ShortForm("hymn"));
            Assert.AreEqual("lynx", kata.ShortForm("lynx"));
            Assert.AreEqual("nymph", kata.ShortForm("nymph"));
            Assert.AreEqual("pygmy", kata.ShortForm("pygmy"));
        }
    }
}