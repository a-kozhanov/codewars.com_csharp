using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class RemoveExclamationMarksTests
    {
        [Test]
        public static void MyTests()
        {
            Assert.AreEqual("", KataRemoveExclamationMarks.RemoveExclamationMarks(""), "Input: Empty string");
            Assert.AreEqual("", KataRemoveExclamationMarks.RemoveExclamationMarks("!"), "Input: " + "!");
            Assert.AreEqual("", KataRemoveExclamationMarks.RemoveExclamationMarks("!!"), "Input: " + "!!");
            Assert.AreEqual("Hi", KataRemoveExclamationMarks.RemoveExclamationMarks("Hi!"), "Input: " + "Hi!");
            Assert.AreEqual("?", KataRemoveExclamationMarks.RemoveExclamationMarks("!?!"), "Input: " + "!?!");
        }
    }
}