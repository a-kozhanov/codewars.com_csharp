using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class KataToLeetSpeakTests
    {
        [TestFixture]
        public class KataTests
        {
            [Test]
            public void BasicTests()
            {
                Assert.AreEqual("1337", KataToLeetSpeak.ToLeetSpeak("LEET"));
                Assert.AreEqual("(0D3W@R$", KataToLeetSpeak.ToLeetSpeak("CODEWARS"));
                Assert.AreEqual("#3110 W0R1D", KataToLeetSpeak.ToLeetSpeak("HELLO WORLD"));
                Assert.AreEqual("10R3M !P$UM D010R $!7 @M37",
                    KataToLeetSpeak.ToLeetSpeak("LOREM IPSUM DOLOR SIT AMET"));
                Assert.AreEqual("7#3 QU!(K 8R0WN F0X JUMP$ 0V3R 7#3 1@2Y D06",
                    KataToLeetSpeak.ToLeetSpeak("THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG"));
            }
        }
    }
}