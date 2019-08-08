using NUnit.Framework;
using CodeWars;

namespace CodeWarsTests
{
    [TestFixture]
    public class StreetFighter2Tests
    {
        private StreetFighter2 kata = new StreetFighter2();
        private string[][] fighters;

        public StreetFighter2Tests()
        {
            this.fighters = new string[][]
            {
              new string[] { "Ryu", "E.Honda", "Blanka", "Guile", "Balrog", "Vega" },
              new string[] { "Ken", "Chun Li", "Zangief", "Dhalsim", "Sagat", "M.Bison" },
            };
        }


        [Test]
        public void _01_ShouldWorkWithFewMoves()
        {
            var moves = new string[] { "up", "left", "right", "left", "left" };
            var expected = new string[] { "Ryu", "Vega", "Ryu", "Vega", "Balrog" };

            CollectionAssert.AreEqual(expected, kata.StreetFighterSelection(fighters, new int[] { 0, 0 }, moves));
        }

        [Test]
        public void _02_ShouldWorkWithNoSelectionCursorMoves()
        {
            var moves = new string[] { };
            var expected = new string[] { };

            CollectionAssert.AreEqual(expected, kata.StreetFighterSelection(fighters, new int[] { 0, 0 }, moves));
        }

        [Test]
        public void _03_ShouldWorkWhenAlwaysMovingLeft()
        {
            var moves = new string[] { "left", "left", "left", "left", "left", "left", "left", "left" };
            var expected = new string[] { "Vega", "Balrog", "Guile", "Blanka", "E.Honda", "Ryu", "Vega", "Balrog" };

            CollectionAssert.AreEqual(expected, kata.StreetFighterSelection(fighters, new int[] { 0, 0 }, moves));
        }

        [Test]
        public void _04_ShouldWorkWhenAlwaysMovingRight()
        {
            var moves = new string[] { "right", "right", "right", "right", "right", "right", "right", "right" };
            var expected = new string[] { "E.Honda", "Blanka", "Guile", "Balrog", "Vega", "Ryu", "E.Honda", "Blanka" };

            CollectionAssert.AreEqual(expected, kata.StreetFighterSelection(fighters, new int[] { 0, 0 }, moves));
        }

        [Test]
        public void _05_ShouldUseAll4DirectionsClockwiseTwice()
        {
            var moves = new string[] { "up", "left", "down", "right", "up", "left", "down", "right" };
            var expected = new string[] { "Ryu", "Vega", "M.Bison", "Ken", "Ryu", "Vega", "M.Bison", "Ken" };

            CollectionAssert.AreEqual(expected, kata.StreetFighterSelection(fighters, new int[] { 0, 0 }, moves));
        }

        [Test]
        public void _06_ShouldWorkWhenAlwaysMovingDown()
        {
            var moves = new string[] { "down", "down", "down", "down" };
            var expected = new string[] { "Ken", "Ken", "Ken", "Ken" };

            CollectionAssert.AreEqual(expected, kata.StreetFighterSelection(fighters, new int[] { 0, 0 }, moves));
        }

        [Test]
        public void _07_ShouldWorkWhenAlwaysMovingUp()
        {
            var moves = new string[] { "up", "up", "up", "up" };
            var expected = new string[] { "Ryu", "Ryu", "Ryu", "Ryu" };

            CollectionAssert.AreEqual(expected, kata.StreetFighterSelection(fighters, new int[] { 0, 0 }, moves));
        }
    }
}