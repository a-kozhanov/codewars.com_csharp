using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class By3OrNotBy3ThatIsQuestionTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.That(By3OrNotBy3ThatIsQuestion.DivisibleByThree("1891009"), Is.EqualTo(false));
            Assert.That(By3OrNotBy3ThatIsQuestion.DivisibleByThree("00009"), Is.EqualTo(true));
            Assert.That(By3OrNotBy3ThatIsQuestion.DivisibleByThree("57"), Is.EqualTo(true));
        }
    }
}