using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class GrasshopperIfElseSyntaxDebugTests
    {
        [Test, Description("Should return the proper result with fixed tests")]
        public void FixedTest()
        {
            GrasshopperIfElseSyntaxDebug greg = new GrasshopperIfElseSyntaxDebug(); //Player greg = new Player();
            greg.Health = 5;
            Assert.AreEqual(true, greg.CheckAlive());

            GrasshopperIfElseSyntaxDebug joe = new GrasshopperIfElseSyntaxDebug(); //Player joe = new Player();
            joe.Health = 0;
            Assert.AreEqual(false, joe.CheckAlive());
        }
    }
}