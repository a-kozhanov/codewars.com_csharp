using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class PreFizzBuzzWorkout1Tests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(new int[] { 1 }, PreFizzBuzzWorkout1.PreFizz(1), "Array should be from 1 to 1");
            Assert.AreEqual(new int[] { 1, 2 }, PreFizzBuzzWorkout1.PreFizz(2), "Array should be from 1 to 2");
            Assert.AreEqual(new int[] { 1, 2, 3 }, PreFizzBuzzWorkout1.PreFizz(3), "Array should be from 1 to 3");
            Assert.AreEqual(new int[] { 1, 2, 3, 4 }, PreFizzBuzzWorkout1.PreFizz(4), "Array should be from 1 to 4");
            Assert.AreEqual(new int[] { 1, 2, 3, 4, 5 }, PreFizzBuzzWorkout1.PreFizz(5), "Array should be from 1 to 5");
        }
    }
}
