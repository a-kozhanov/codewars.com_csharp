using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SimpleStringCharactersTests
    {
        [Test]
        public void ExampleTests()
        {
            Assert.AreEqual(new int[] {1, 18, 3, 2}, SimpleStringCharacters.solve("Codewars@codewars123.com"));
            Assert.AreEqual(new int[] {7, 6, 3, 2}, SimpleStringCharacters.solve("bgA5<1d-tOwUZTS8yQ"));
            Assert.AreEqual(new int[] {9, 9, 6, 9}, SimpleStringCharacters.solve("P*K4%>mQUDaG$h=cx2?.Czt7!Zn16p@5H"));
            Assert.AreEqual(new int[] {15, 8, 6, 9},
                SimpleStringCharacters.solve("RYT'>s&gO-.CM9AKeH?,5317tWGpS<*x2ukXZD"));
        }
    }
}