using CodeWars;
using NUnit.Framework;

namespace CodeWarsTests
{
    [TestFixture]
    public class AD2070HelpLorimarTests
    {
        [Test]
        public void BasicTests()
        {
            var sensorData1 = new[]
            {
                new object[] {"Distance:", 116.28, "Meters", "Sensor 5 malfunction =>lorimar"},
                new object[] {"Distance:", 117.1, "Meters", "Sensor 5 malfunction =>lorimar"},
                new object[] {"Distance:", 123.96, "Meters", "Sensor 5 malfunction =>lorimar"},
                new object[] {"Distance:", 117.17, "Meters", "Sensor 5 malfunction =>lorimar"}
            };
            Assert.AreEqual(AD2070HelpLorimar.SensorAnalysis(sensorData1), new double[] {118.6275, 3.5779});

            var sensorData2 = new[]
            {
                new object[] {"Distance:", 295.68, "Meters", "Sensor 5 malfunction =>lorimar"},
                new object[] {"Distance:", 294.78, "Meters", "Sensor 5 malfunction =>lorimar"},
                new object[] {"Distance:", 298.21, "Meters", "Sensor 5 malfunction =>lorimar"},
                new object[] {"Distance:", 294.84, "Meters", "Sensor 5 malfunction =>lorimar"},
                new object[] {"Distance:", 296.54, "Meters", "Sensor 5 malfunction =>lorimar"},
                new object[] {"Distance:", 133.84, "Meters", "Sensor 5 malfunction =>lorimar"},
                new object[] {"Distance:", 294.41, "Meters", "Sensor 5 malfunction =>lorimar"},
                new object[] {"Distance:", 294.82, "Meters", "Sensor 5 malfunction =>lorimar"},
                new object[] {"Distance:", 134.61, "Meters", "Sensor 5 malfunction =>lorimar"},
                new object[] {"Distance:", 294.86, "Meters", "Sensor 5 malfunction =>lorimar"},
                new object[] {"Distance:", 170.88, "Meters", "Sensor 5 malfunction =>lorimar"},
                new object[] {"Distance:", 170.87, "Meters", "Sensor 5 malfunction =>lorimar"},
                new object[] {"Distance:", 170.47, "Meters", "Sensor 5 malfunction =>lorimar"},
                new object[] {"Distance:", 135.5, "Meters", "Sensor 5 malfunction =>lorimar"},
                new object[] {"Distance:", 170.9, "Meters", "Sensor 5 malfunction =>lorimar"},
                new object[] {"Distance:", 170.08, "Meters", "Sensor 5 malfunction =>lorimar"},
                new object[] {"Distance:", 171.36, "Meters", "Sensor 5 malfunction =>lorimar"},
                new object[] {"Distance:", 170.08, "Meters", "Sensor 5 malfunction =>lorimar"},
                new object[] {"Distance:", 170.92, "Meters", "Sensor 5 malfunction =>lorimar"},
                new object[] {"Distance:", 170.88, "Meters", "Sensor 5 malfunction =>lorimar"}
            };
            Assert.AreEqual(AD2070HelpLorimar.SensorAnalysis(sensorData2), new double[] {215.2265, 68.4014});
        }
    }
}