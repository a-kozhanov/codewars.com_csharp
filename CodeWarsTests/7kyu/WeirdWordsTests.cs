using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class WeirdWordsTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual("Nz Obnf Jt App", WeirdWords.NextLetter("My Name Is Zoo"));
            Assert.AreEqual("Xibu jt zpvs obnf", WeirdWords.NextLetter("What is your name"));
            Assert.AreEqual("aPp", WeirdWords.NextLetter("zOo"));
        }
    }
}