using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class AddLengthTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(new string[] { "apple 5", "ban 3" }, KataAddLength.AddLength("apple ban"));
            Assert.AreEqual(new string[] { "you 3", "will 4", "win 3" }, KataAddLength.AddLength("you will win"));
        }
    }
}