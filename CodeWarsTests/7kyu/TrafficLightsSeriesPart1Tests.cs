using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class TrafficLightsSeriesPart1Tests
    {
        [Test]
        public void GivenTrafficLight_ThenInterfaceIsImplemented()
        {
            // ARRANGE
            var trafficLight = new TrafficLightsSeriesPart1();

            // ACT
            var actual = trafficLight is ITrafficLight;

            // ASSERT
            Assert.IsTrue(actual);
        }

        [Test]
        public void GivenTrafficLight_WhenInstatiated_ThenRedLightIsOn_AndOthersAreOff()
        {
            // ARRANGE
            var trafficLight = new TrafficLightsSeriesPart1();

            // ACT
            var amberActual = trafficLight.IsAmberOn;
            var greenActual = trafficLight.IsGreenOn;
            var redActual = trafficLight.IsRedOn;

            // ASSERT
            Assert.IsFalse(amberActual);
            Assert.IsFalse(greenActual);
            Assert.IsTrue(redActual);
        }

        [Test]
        public void GivenInstatiatedTrafficLight_WhenSetToAmberState_ThenAmberLightIsOn_AndOtherLightsAreOff()
        {
            // ARRANGE
            var trafficLight = new TrafficLightsSeriesPart1();

            // ACT
            trafficLight.Set(State.Amber);
            var amberActual = trafficLight.IsAmberOn;
            var greenActual = trafficLight.IsGreenOn;
            var redActual = trafficLight.IsRedOn;

            // ASSERT
            Assert.IsTrue(amberActual);
            Assert.IsFalse(greenActual);
            Assert.IsFalse(redActual);
        }

        [Test]
        public void GivenInstatiatedTrafficLight_WhenSetToGreenState_ThenGreenLightIsOn_AndGreenIsOff()
        {
            // ARRANGE
            var trafficLight = new TrafficLightsSeriesPart1();

            // ACT
            trafficLight.Set(State.Green);
            var amberActual = trafficLight.IsAmberOn;
            var greenActual = trafficLight.IsGreenOn;
            var redActual = trafficLight.IsRedOn;

            // ASSERT
            Assert.IsFalse(amberActual);
            Assert.IsTrue(greenActual);
            Assert.IsFalse(redActual);
        }

        [Test]
        public void GivenInstatiatedTrafficLight_WhenSetToRedAmberState_ThenRedLightAndAmberLightIsOn_AndGreenIsOff()
        {
            // ARRANGE
            var trafficLight = new TrafficLightsSeriesPart1();

            // ACT
            trafficLight.Set(State.RedAmber);
            var amberActual = trafficLight.IsAmberOn;
            var greenActual = trafficLight.IsGreenOn;
            var redActual = trafficLight.IsRedOn;

            // ASSERT
            Assert.IsTrue(amberActual);
            Assert.IsFalse(greenActual);
            Assert.IsTrue(redActual);
        }

        [Test]
        public void GivenInstatiatedTrafficLight_WhenSetToRedState_ThenRedLightLightIsOn_AndOthersAreOff()
        {
            // ARRANGE
            var trafficLight = new TrafficLightsSeriesPart1();

            // ACT
            trafficLight.Set(State.Red);
            var amberActual = trafficLight.IsAmberOn;
            var greenActual = trafficLight.IsGreenOn;
            var redActual = trafficLight.IsRedOn;

            // ASSERT
            Assert.IsFalse(amberActual);
            Assert.IsFalse(greenActual);
            Assert.IsTrue(redActual);
        }
    }
}