using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class ThinkingTestingMathOfMiddleSchoolTests
    {
        [Test]
        public void TestCase()
        {
            var kata = new ThinkingTestingMathOfMiddleSchool();
            //Add? subtract? multiply? divide? Who and who?
            //Tips:Hard Version of Thinking & Testing 07
            Assert.AreEqual(new int[] {0, 0, 0, 0}, kata.Testit(new int[] {0, 0, 0, 0}, new int[] {0, 0, 0, 0}), "");
            Assert.AreEqual(new int[] {0, 11000, 0, 0},
                kata.Testit(new int[] {22, 88, 0, 0}, new int[] {0, 100, 0, 100}), "");
            Assert.AreEqual(new int[] {0, 0, 10853, 0}, kata.Testit(new int[] {0, 0, 96, 49}, new int[] {86, 0, 53, 0}),
                "");
            Assert.AreEqual(new int[] {0, 0, 0, 10953}, kata.Testit(new int[] {0, 0, 83, 88}, new int[] {0, 27, 0, 99}),
                "");
            //click "Submit" try more testcase...
        }
    }
}