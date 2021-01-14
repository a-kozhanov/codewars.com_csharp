using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SimpleFun30StringsConstructionTests
    {
        [Test]
        public void BasicTests()
        {
            var kata = new SimpleFun30StringsConstruction();
            Assert.AreEqual(2, kata.StringsConstruction("abc", "abccba"));
            Assert.AreEqual(3, kata.StringsConstruction("hnccv", "hncvohcjhdfnhonxddcocjncchnvohchnjohcvnhjdhihsn"));
            Assert.AreEqual(0, kata.StringsConstruction("abc", "def"));
            Assert.AreEqual(3, kata.StringsConstruction("zzz", "zzzzzzzzzzz"));
        }
    }
}