using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class ReturnStringOfFirstCharactersTests
    {
        [Test]
        public static void TestExample0()
        {
            Assert.AreEqual("cia",
                ReturnStringOfFirstCharacters.MakeString("coding is awesome"));
        }
    }
}