using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class ComplementaryDNATests
    {
        [TestCase]
        public void test01()
        {
            Assert.AreEqual("TTTT", ComplementaryDNA.MakeComplement("AAAA"));
        }
        [TestCase]
        public void test02()
        {
            Assert.AreEqual("TAACG", ComplementaryDNA.MakeComplement("ATTGC"));
        }
        [TestCase]
        public void test03()
        {
            Assert.AreEqual("CATA", ComplementaryDNA.MakeComplement("GTAT"));
        }
    }
}