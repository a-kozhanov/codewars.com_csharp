using System;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class Contamination1StringTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual("zzz", Contamination1String.Contamination("abc", "z"));
            Assert.AreEqual("", Contamination1String.Contamination("", "z"));
            Assert.AreEqual("", Contamination1String.Contamination("abc", String.Empty));
            Assert.AreEqual("&&&&&&&&", Contamination1String.Contamination("_3ebzgh4", "&"));
            Assert.AreEqual("      ", Contamination1String.Contamination("//case", " "));
        }
    }
}