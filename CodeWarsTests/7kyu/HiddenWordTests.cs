using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class HiddenWordTests
    {
        [TestCase]
        public void BasicTest1()
        {
            HiddenWord kata = new HiddenWord();
            Assert.AreEqual("aid", kata.hidden(637));
        }

        [TestCase]
        public void BasicTest2()
        {
            HiddenWord kata = new HiddenWord();
            Assert.AreEqual("debt", kata.hidden(7415));
        }

        [TestCase]
        public void BasicTest3()
        {
            HiddenWord kata = new HiddenWord();
            Assert.AreEqual("email", kata.hidden(49632));
        }

        [TestCase]
        public void BasicTest4()
        {
            HiddenWord kata = new HiddenWord();
            Assert.AreEqual("melted", kata.hidden(942547));
        }
    }
}