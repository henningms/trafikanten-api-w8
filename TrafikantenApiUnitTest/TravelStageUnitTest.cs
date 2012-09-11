using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using System;
using System.Linq;
using System.Threading.Tasks;
using TrafikantenApi.Service.ApiClient;

namespace TrafikantenApiUnitTest
{
    [TestClass]
    public class TravelStageUnitTest
    {
        private static readonly DateTime Time = DateTime.Now.AddDays(1) + (new TimeSpan(9, 15, 0));

        [TestMethod]
        public async Task TestGetArrivals()
        {
            var result = await TravelStage.GetArrivals(3011320, Time);

            Assert.IsNotNull(result);
            Assert.AreEqual(true, result.Any());
        }

        [TestMethod]
        public async Task TestGetArrivalsAdvanced()
        {
            var result = await TravelStage.GetArrivalsAdvanced(3012501, Time, new[] {"31", "20"}, "Bus");

            Assert.IsNotNull(result);
            Assert.AreEqual(true, result.Any());
        }

        [TestMethod]
        public async Task TestGetDepartures()
        {
            var result = await TravelStage.GetDepartures(3011320, Time);

            Assert.IsNotNull(result);
            Assert.AreEqual(true, result.Any());
        }

        [TestMethod]
        public async Task TestGetDeparturesAdvanced()
        {
            var result = await TravelStage.GetDeparturesAdvanced(3012501, Time, new[] { "31", "20" }, "Bus");

            Assert.IsNotNull(result);
            Assert.AreEqual(true, result.Any());
        }

    }
}
