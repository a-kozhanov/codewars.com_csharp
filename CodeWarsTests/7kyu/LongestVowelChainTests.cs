using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class LongestVowelChainTests
    {
        [Test, Description("Basic Tests")]
        public void SampleTest()
        {
            Assert.AreEqual(2, LongestVowelChain.Solve("codewarriors"));
            Assert.AreEqual(3, LongestVowelChain.Solve("suoidea"));
            Assert.AreEqual(3, LongestVowelChain.Solve("ultrarevolutionariees"));
            Assert.AreEqual(1, LongestVowelChain.Solve("strengthlessnesses"));
            Assert.AreEqual(2, LongestVowelChain.Solve("cuboideonavicuare"));
            Assert.AreEqual(5, LongestVowelChain.Solve("chrononhotonthuooaos"));
            Assert.AreEqual(8, LongestVowelChain.Solve("iiihoovaeaaaoougjyaw"));
        }
    }
}