using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class CleanUpAfterYourDogTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual("Clean",
                CleanUpAfterYourDog.Crap(new char[,] {{'_', '_', '_', '_'}, {'_', '_', '_', '@'}, {'_', '_', '@', '_'}},
                    2, 2));

            Assert.AreEqual("Cr@p",
                CleanUpAfterYourDog.Crap(new char[,] {{'_', '_', '_', '_'}, {'_', '_', '_', '@'}, {'_', '_', '@', '_'}},
                    1, 1));

            Assert.AreEqual("Dog!!", CleanUpAfterYourDog.Crap(new char[,] {{'_', '_'}, {'_', '@'}, {'D', '_'}}, 2, 2));
        }
    }
}