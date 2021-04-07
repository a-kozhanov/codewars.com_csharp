using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class ThinkingTestingSportStarTests
    {
        [Test]
        public void TestCase()
        {
            var kata = new ThinkingTestingSportStar();
            //I am a sports star, I never make mistakes in the game  ;-)
            Assert.AreEqual("_|_|_", kata.Testit(new string[] {"run", "jump", "run", "jump", "run"}, "_|_|_"), "");
            Assert.AreEqual("_|_/_", kata.Testit(new string[] {"run", "jump", "run", "run", "run"}, "_|_|_"), "");
            Assert.AreEqual("_/_/_", kata.Testit(new string[] {"run", "run", "run", "run", "run"}, "_|_|_"), "");
            Assert.AreEqual("x|x|x", kata.Testit(new string[] {"jump", "jump", "jump", "jump", "jump"}, "_|_|_"), "");
            Assert.AreEqual("x/x/x", kata.Testit(new string[] {"jump", "run", "jump", "run", "jump"}, "_|_|_"), "");
            //click "Submit" try more testcase...
        }
    }
}