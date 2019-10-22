using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class ArrayMadnessTests
    {
        [Test, Description("Should work for sample tests")]
        public void SampleTest()
        {
            Assert.AreEqual(true, KataArrayMadness.ArrayMadness(new int[] { 4, 5, 6 }, new int[] { 1, 2, 3 }));
            Assert.AreEqual(false, KataArrayMadness.ArrayMadness(new int[] { 5, 6, 7 }, new int[] { 4, 5, 6 }));
        }
    }
}