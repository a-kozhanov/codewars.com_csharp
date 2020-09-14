using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class ExtractFileNameTests
    {
        [Test]
        public void ExampleTests()
        {
            Assert.AreEqual("FILE_NAME.EXTENSION",
                KataExtractFileName.ExtractFileName("1_FILE_NAME.EXTENSION.OTHEREXTENSIONadasdassdassds34"));
            Assert.AreEqual("FILE_NAME.EXTENSION",
                KataExtractFileName.ExtractFileName("1231231223123131_FILE_NAME.EXTENSION.OTHEREXTENSION"));
        }
    }
}