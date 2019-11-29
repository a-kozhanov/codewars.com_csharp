using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class GrasshopperBugSquashingTests
    {
        [Test, Description("GrasshopperBugSquashing should define variables and store values")]
        public void VariableTest()
        {
            Assert.AreEqual(100, GrasshopperBugSquashing.Health);
            Assert.AreEqual(0, GrasshopperBugSquashing.Position);
            Assert.AreEqual(0, GrasshopperBugSquashing.Coins);
        }

        [Test, Description("PlayTurn should not throw an exception")]
        public void ErrorTest()
        {
            Assert.DoesNotThrow(() => GrasshopperBugSquashing.PlayTurn());
        }

        [Test, Description("should roll dice first")]
        public void OrderTest1()
        {
            Assert.AreEqual("RollDice", actual: GrasshopperBugSquashing.Log[0]);
        }

        [Test, Description("should move second")]
        public void OrderTest2()
        {
            Assert.AreEqual("Move", GrasshopperBugSquashing.Log[1]);
        }

        [Test, Description("should combat third")]
        public void OrderTest3()
        {
            Assert.AreEqual("Combat", GrasshopperBugSquashing.Log[2]);
        }

        [Test, Description("should get coins fourth")]
        public void OrderTest4()
        {
            Assert.AreEqual("GetCoins", GrasshopperBugSquashing.Log[3]);
        }

        [Test, Description("should buy health fifth")]
        public void OrderTest5()
        {
            Assert.AreEqual("BuyHealth", GrasshopperBugSquashing.Log[4]);
        }

        [Test, Description("should print status sixth")]
        public void OrderTest6()
        {
            Assert.AreEqual("PrintStatus", GrasshopperBugSquashing.Log[5]);
        }
    }
}