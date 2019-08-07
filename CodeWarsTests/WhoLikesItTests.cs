using NUnit.Framework;
using CodeWars;

namespace CodeWarsTests
{
    [TestFixture]
    public class WhoLikesItTests
    {
        [Test, Description("It should return correct text")]
        public void SampleTest()
        {
            Assert.AreEqual("no one likes this", WhoLikesIt.Likes(new string[0]));
            Assert.AreEqual("Peter likes this", WhoLikesIt.Likes(new string[] { "Peter" }));
            Assert.AreEqual("Jacob and Alex like this", WhoLikesIt.Likes(new string[] { "Jacob", "Alex" }));
            Assert.AreEqual("Max, John and Mark like this", WhoLikesIt.Likes(new string[] { "Max", "John", "Mark" }));
            Assert.AreEqual("Alex, Jacob and 2 others like this", WhoLikesIt.Likes(new string[] { "Alex", "Jacob", "Mark", "Max" }));
        }

    }
}