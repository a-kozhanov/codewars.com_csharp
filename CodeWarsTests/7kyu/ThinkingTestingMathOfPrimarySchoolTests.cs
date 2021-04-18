using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class ThinkingTestingMathOfPrimarySchoolTests
    {
        [Test]
        public void TestCase()
        {
            var kata = new ThinkingTestingMathOfPrimarySchool();
            //Add? subtract? multiply? divide? Who and who?
            Assert.AreEqual(0, kata.Testit(new int[] {0, 0, 0, 0}), "");
            Assert.AreEqual(0, kata.Testit(new int[] {0, 0, 0, 1}), "");
            Assert.AreEqual(0, kata.Testit(new int[] {0, 0, 1, 1}), "");
            Assert.AreEqual(0, kata.Testit(new int[] {0, 1, 0, 1}), "");
            Assert.AreEqual(1, kata.Testit(new int[] {0, 1, 1, 0}), "");
            Assert.AreEqual(1, kata.Testit(new int[] {1, 0, 0, 1}), "");
            //click "Submit" try more testcase...
        }
    }
}