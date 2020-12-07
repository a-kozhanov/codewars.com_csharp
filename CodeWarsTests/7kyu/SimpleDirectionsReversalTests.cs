using System;
using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class SimpleDirectionsReversalTests
    {
        [Test]
        public void ExampleTests()
        {
            Assert.AreEqual(new String[] {"Begin on Road D", "Right on Road C", "Left on Road B", "Left on Road A"},
                SimpleDirectionsReversal.solve(new String[]
                    {"Begin on Road A", "Right on Road B", "Right on Road C", "Left on Road D"}));

            Assert.AreEqual(new String[] {"Begin on 9th Dr", "Right on First Road", "Left on 3rd Blvd"},
                SimpleDirectionsReversal.solve(new String[]
                    {"Begin on 3rd Blvd", "Right on First Road", "Left on 9th Dr"}));

            Assert.AreEqual(new String[] {"Begin on Road A"},
                SimpleDirectionsReversal.solve(new String[] {"Begin on Road A"}));
        }
    }
}