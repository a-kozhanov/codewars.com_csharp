using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class KatastropheTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual("Safe!",
                Katastrophe.StrongEnough(new int[][] {new int[] {2, 3, 1}, new int[] {3, 1, 1,}, new int[] {1, 1, 2}},
                    2));

            Assert.AreEqual("Safe!",
                Katastrophe.StrongEnough(new int[][] {new int[] {5, 8, 7}, new int[] {3, 3, 1,}, new int[] {4, 1, 2}},
                    2));

            Assert.AreEqual("Needs Reinforcement!",
                Katastrophe.StrongEnough(new int[][] {new int[] {5, 8, 7}, new int[] {3, 3, 1,}, new int[] {4, 1, 2}},
                    3));
        }
    }
}