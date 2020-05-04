using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class KataSplitInPartsTests
    {
        [TestCase]
        //Fixed values
        public void splitString1()
        {
            string str = "supercalifragilisticexpialidocious";
            Assert.AreEqual("sup erc ali fra gil ist ice xpi ali doc iou s", KataSplitInParts.SplitInParts(str, 3));
        }

        [TestCase]
        //Fixed values
        public void splitString2()
        {
            string str = "HelloKata";
            Assert.AreEqual("Hel loK ata", KataSplitInParts.SplitInParts(str, 3));
        }

        [TestCase]
        //Fixed values
        public void splitString3()
        {
            string str = "HelloKata";
            Assert.AreEqual("H e l l o K a t a", KataSplitInParts.SplitInParts(str, 1));
        }

        [TestCase]
        //Fixed values
        public void splitString4()
        {
            string str = "HelloKata";
            Assert.AreEqual("HelloKata", KataSplitInParts.SplitInParts(str, 9));
        }
    }
}