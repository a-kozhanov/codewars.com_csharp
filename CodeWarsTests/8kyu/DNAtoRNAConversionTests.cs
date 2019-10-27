using System;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class DNAtoRNAConversionTests
    {
        [Test]
        public void test()
        {
            Assert.AreEqual("UUUU", DNAtoRNAConversion.dnaToRna("TTTT"));
        }
    }
}