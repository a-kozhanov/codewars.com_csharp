using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class AirportItineraryTests
    {
        [Test]
        public void SimpleTest()
        {
            var travel = new[]
            {
                new AirportItinerary.Route {In = "TRN", Out = "FCO"}
            };
            Assert.AreEqual("TRN-FCO", AirportItinerary.Itinerary(travel));
        }

        [Test]
        public void MultipleTest()
        {
            var travel = new[]
            {
                new AirportItinerary.Route {In = "TRN", Out = "FCO"},
                new AirportItinerary.Route {In = "CIA", Out = "JFK"}
            };
            Assert.AreEqual("TRN-FCO-CIA-JFK", AirportItinerary.Itinerary(travel));
        }

        [Test]
        public void SameAirportsAreSkippedTest()
        {
            var travel = new[]
            {
                new AirportItinerary.Route {In = "TRN", Out = "FCO"},
                new AirportItinerary.Route {In = "FCO", Out = "JFK"}
            };
            Assert.AreEqual("TRN-FCO-JFK", AirportItinerary.Itinerary(travel));
        }

        [Test]
        public void RoundTripAreConservedTest()
        {
            var travel = new[]
            {
                new AirportItinerary.Route {In = "TRN", Out = "FCO"},
                new AirportItinerary.Route {In = "CIA", Out = "TRN"}
            };
            Assert.AreEqual("TRN-FCO-CIA-TRN", AirportItinerary.Itinerary(travel));
        }

        [Test]
        public void RoundTripAreConservedWithSharedAirportsTest()
        {
            var travel = new[]
            {
                new AirportItinerary.Route {In = "TRN", Out = "FCO"},
                new AirportItinerary.Route {In = "FCO", Out = "TRN"}
            };
            Assert.AreEqual("TRN-FCO-TRN", AirportItinerary.Itinerary(travel));
        }
    }
}