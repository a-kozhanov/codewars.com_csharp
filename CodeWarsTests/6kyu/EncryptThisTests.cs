using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class KataEncryptThisTests
    {
        public class ExampleTests
        {
            [TestCase("", "")]
            [TestCase("A", "65")]
            [TestCase("Ab", "65b")]
            [TestCase("Abc", "65cb")]
            [TestCase("Abcd", "65dcb")]
            [TestCase("A wise old owl lived in an oak", "65 119esi 111dl 111lw 108dvei 105n 97n 111ka")]
            [TestCase("The more he saw the less he spoke", "84eh 109ero 104e 115wa 116eh 108sse 104e 115eokp")]
            [TestCase("The less he spoke the more he heard", "84eh 108sse 104e 115eokp 116eh 109ero 104e 104dare")]
            [TestCase("Why can we not all be like that wise old bird",
                "87yh 99na 119e 110to 97ll 98e 108eki 116tah 119esi 111dl 98dri")]
            [TestCase("Thank you Piotr for all your help", "84kanh 121uo 80roti 102ro 97ll 121ruo 104ple")]
            public void SampleTests(string input, string expected)
            {
                Assert.AreEqual(expected, KataEncryptThis.EncryptThis(input));
            }
        }
    }
}