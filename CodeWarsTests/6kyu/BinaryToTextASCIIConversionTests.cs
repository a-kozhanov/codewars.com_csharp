using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class BinaryToTextASCIIConversionTests
    {
        [Test]
        public void Basic_Tests()
        {
            Assert.AreEqual("", BinaryToTextASCIIConversion.BinaryToString(""));

            Assert.AreEqual("Hello",
                BinaryToTextASCIIConversion.BinaryToString("0100100001100101011011000110110001101111"));
        }
    }
}