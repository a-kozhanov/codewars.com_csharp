using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class DirectionsReductionTests
    {
        [Test]
        public void Test1()
        {
            string[] a = new string[] {"NORTH", "SOUTH", "SOUTH", "EAST", "WEST", "NORTH", "WEST"};
            string[] b = new string[] {"WEST"};
            Assert.AreEqual(b, DirectionsReduction.dirReduc(a));
        }

        [Test]
        public void Test2()
        {
            string[] a = new string[] {"NORTH", "WEST", "SOUTH", "EAST"};
            string[] b = new string[] {"NORTH", "WEST", "SOUTH", "EAST"};
            Assert.AreEqual(b, DirectionsReduction.dirReduc(a));
        }
    }
}