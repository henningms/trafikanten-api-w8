using System;
using System.Linq;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using System.Threading.Tasks;

namespace TrafikantenApiUnitTest
{
    [TestClass]
    public class TripUnitTest
    {
        [TestMethod]
        public async Task TestGetTrip()
        {
            var result = await TrafikantenApi.Service.ApiClient.Trip.GetTrip(35735,
                TrafikantenApi.Helpers.DateHelper.DateTimeToTimeString(DateTime.Now.AddDays(1).AddHours(-12)));

            Assert.IsNotNull(result);
            Assert.AreEqual(35735, result.ID);
            Assert.AreEqual("Bekkelaget", result.Stops.First().Name);
        }
    }
}
