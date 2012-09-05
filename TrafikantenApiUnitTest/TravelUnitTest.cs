using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrafikantenApi.Service.ApiClient;

namespace TrafikantenApiUnitTest
{
    [TestClass]
    public class TravelUnitTest
    {
        private static DateTime timeToTest = DateTime.Now.AddDays(1) + new TimeSpan(9, 15, 0);

        [TestMethod]
        public async Task TestGetTravelsAfter()
        {
            var result = await Travel.GetTravelsAfter(timeToTest, 3011320, 3010013);

            Assert.IsNotNull(result);
            Assert.AreEqual(true, result.Any());
        }

        [TestMethod]
        public async Task TestGetTravelsAfterByStops()
        {
            var result = await Travel.GetTravelsAfterByStops(timeToTest, 3011320, 3010013);

            Assert.IsNotNull(result);
            Assert.AreEqual(true, result.Any());

        }

        [TestMethod]
        public async Task TestGetTravelsBefore()
        {
            var result = await Travel.GetTravelsBefore(timeToTest, 3011320, 3010013);

            Assert.IsNotNull(result);
            Assert.AreEqual(true, result.Any());
        }

        [TestMethod]
        public async Task TestGetTravelsBeforeByStops()
        {
            var result = await Travel.GetTravelsBeforeByStops(timeToTest, 3011320, 3010013);

            Assert.IsNotNull(result);
            Assert.AreEqual(true, result.Any());
        }

        [TestMethod]
        public async Task TestGetTravelsAdvanced()
        {
            var result = await Travel.GetTravelsAdvanced(timeToTest, 3011320, 3010013, 2, 2, 100,
                true, 7, "Bus", "Train", "Tram");

            Assert.IsNotNull(result);
            Assert.AreEqual(true, result.Any());
        }

        [TestMethod]
        public async Task TestGetTravelsAdvancedByCoordinates()
        {
            var result = await Travel.GetTravelsAdvancedByCoordinates(timeToTest, 599290, 6643320, 596895, 6643255, 2, 2, 100,
                true, 7, "Bus", "Train", "Tram");

            Assert.IsNotNull(result);
            Assert.AreEqual(true, result.Any());
        }
    }
}
