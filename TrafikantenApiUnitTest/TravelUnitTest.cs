using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using System;
using System.Linq;
using System.Threading.Tasks;
using TrafikantenApi.Service.ApiClient;

namespace TrafikantenApiUnitTest
{
    [TestClass]
    public class TravelUnitTest
    {
        private static readonly DateTime TimeToTest = DateTime.Now.AddDays(1) + new TimeSpan(9, 15, 0);

        [TestMethod]
        public async Task TestGetTravelsAfter()
        {
            var result = await Travel.GetTravelsAfter(TimeToTest, 3011320, 3010013);

            Assert.IsNotNull(result);
            Assert.AreEqual(true, result.Any());
        }

        [TestMethod]
        public async Task TestGetTravelsAfterByStops()
        {
            var result = await Travel.GetTravelsAfterByStops(TimeToTest, 3011320, 3010013);

            Assert.IsNotNull(result);
            Assert.AreEqual(true, result.Any());

        }

        [TestMethod]
        public async Task TestGetTravelsBefore()
        {
            var result = await Travel.GetTravelsBefore(TimeToTest, 3011320, 3010013);

            Assert.IsNotNull(result);
            Assert.AreEqual(true, result.Any());
        }

        [TestMethod]
        public async Task TestGetTravelsBeforeByStops()
        {
            var result = await Travel.GetTravelsBeforeByStops(TimeToTest, 3011320, 3010013);

            Assert.IsNotNull(result);
            Assert.AreEqual(true, result.Any());
        }

        [TestMethod]
        public async Task TestGetTravelsAdvanced()
        {
            var result = await Travel.GetTravelsAdvanced(TimeToTest, 3011320, 3010013, 2, 2, 100,
                true, 7, "Bus", "Train", "Tram");

            Assert.IsNotNull(result);
            Assert.AreEqual(true, result.Any());
        }

        [TestMethod]
        public async Task TestGetTravelsAdvancedByCoordinates()
        {
            var result = await Travel.GetTravelsAdvancedByCoordinates(TimeToTest, 599290, 6643320, 596895, 6643255, 2, 2, 100,
                true, 7, "Bus", "Train", "Tram");

            Assert.IsNotNull(result);
            Assert.AreEqual(true, result.Any());
        }
    }
}
