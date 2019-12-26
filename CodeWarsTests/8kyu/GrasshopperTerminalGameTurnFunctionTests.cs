using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class GrasshopperTerminalGameTurnFunctionTests
    {
        [Test, Description("One Turn")]
        public void Test()
        {
            GrasshopperTerminalGameTurnFunction.DoTurn();
    
            // Assert.AreEqual(6, Log.Count, "should call all 6 functions");
            // Assert.AreEqual("RollDice", Log[0], "should roll dice first");
            // Assert.AreEqual("Move", Log[1], "should move second");
            // Assert.AreEqual("Combat", Log[2], "should combat third");
            // Assert.AreEqual("GetCoins", Log[3], "should get coins fourth");
            // Assert.AreEqual("BuyHealth", Log[4], "should buy health fifth");
            // Assert.AreEqual("PrintStatus", Log[5], "should print status sixth");
        }        
    }
}