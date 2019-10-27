using System;
using System.Linq;
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


        private static Random rnd = new Random();
        public static string[] names = new string[100].Select(_ => MakeWord()).ToArray();

        public static string MakeWord() =>
            String.Concat(new char[5].Select(_ => (char)rnd.Next(97, 123)));

        [Test, Description("Should return correct text for 0 names")]
        public void ZeroNameTest()
        {
            Assert.AreEqual(WhoLikesIt.Likes(new string[0]), WhoLikesIt.Likes(new string[0]));
        }

        [Test, Description("Should return correct text for 1 name")]
        public void OneNameTest()
        {
            Assert.AreEqual(WhoLikesIt.Likes(names.Take(1).ToArray()), WhoLikesIt.Likes(names.Take(1).ToArray()));
        }

        [Test, Description("Should return correct text for 2 names")]
        public void TwoNameTest()
        {
            Assert.AreEqual(WhoLikesIt.Likes(names.Take(2).ToArray()), WhoLikesIt.Likes(names.Take(2).ToArray()));
        }

        [Test, Description("Should return correct text for 3 names")]
        public void ThreeNameTest()
        {
            Assert.AreEqual(WhoLikesIt.Likes(names.Take(3).ToArray()), WhoLikesIt.Likes(names.Take(3).ToArray()));
        }

        [Test, Description("Should return correct text for 4 or more names")]
        public void FourNameTest()
        {
            // 4 names
            Assert.AreEqual(WhoLikesIt.Likes(names.Take(4).ToArray()), WhoLikesIt.Likes(names.Take(4).ToArray()));

            const int Tests = 1000;

            for (int i = 0; i < Tests; ++i)
            {
                names = names.OrderBy(_ => rnd.Next()).ToArray();
                string[] test = names.Take(rnd.Next(0, 101)).ToArray();

                string expected = WhoLikesIt.Likes(test);
                string actual = WhoLikesIt.Likes(test);

                Assert.AreEqual(expected, actual);
            }
        }

    }
}