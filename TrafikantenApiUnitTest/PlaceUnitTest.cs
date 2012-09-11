using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;

namespace TrafikantenApiUnitTest
{
    [TestClass]
    public class PlaceUnitTest
    {
        [TestMethod]
        public async Task TestFindMatches()
        {
            var result = await TrafikantenApi.Service.ApiClient.Place.FindMatches("skøyen");

            Assert.IsNotNull(result);
            Assert.AreEqual("Skøyen #", result.First().Name);
        }

        [TestMethod]
        public async Task TestFindMatchesByCounties()
        {
            var result =
                await
                TrafikantenApi.Service.ApiClient.Place.FindMatchesByCounties("skøyen", "ostfold", "oslo", "akershus");

            Assert.IsNotNull(result);
            Assert.AreEqual("Skøyen #", result.First().Name);
        }

        [TestMethod]
        public async Task TestFindPlacesByCounties()
        {
            var result =
                await
                TrafikantenApi.Service.ApiClient.Place.FindPlacesByCounties("skøyen", "ostfold", "oslo", "akershus");

            Assert.IsNotNull(result);
            Assert.AreEqual("Skøyen #", result.First().Name);
        }

        [TestMethod]
        public async Task TestFindPlaceBasedOnId()
        {
            var result = await TrafikantenApi.Service.ApiClient.Place.FindPlaceBasedOnPlaceId(3011320, "skøyen");

            Assert.IsNotNull(result);
            Assert.AreEqual("Skøyenåsen [T-bane]", result.Name);
        }

        [TestMethod]
        public async Task TestGetStopsByPlaceId()
        {
            var result = await TrafikantenApi.Service.ApiClient.Place.GetStopsByPlaceId(1000023243);

            Assert.IsNotNull(result);
            Assert.AreEqual("Skøyen [tog]", result.First().Name);
        }

        [TestMethod]
        public async Task TestGetClosestStopsByCoordinates()
        {
            var result =
                await TrafikantenApi.Service.ApiClient.Place.GetClosestStopsByCoordinates(593918, 6644077, 7);

            Assert.IsNotNull(result);
            Assert.AreEqual("Skøyenbrua (i Hoffsveien)", result.First().Name);
        }

        [TestMethod]
        public async Task TestGetClosestStopsAdvancedByCoordinates()
        {
            var result =
                await
                TrafikantenApi.Service.ApiClient.Place.GetClosestStopsAdvancedByCoordinates(593918, 6644077, 8, 1200);

            Assert.IsNotNull(result);
            Assert.AreEqual("Skøyenbrua (i Hoffsveien)", result.First().Name);
        }

        [TestMethod]
        public async Task TestGetLines()
        {
           var result = await TrafikantenApi.Service.ApiClient.Place.GetLines(3010010);

            Assert.IsNotNull(result);
            Assert.AreEqual(300, result.First().LineID);
        }

        [TestMethod]
        public async Task TestAutocomplete()
        {
            var result = await TrafikantenApi.Service.ApiClient.Place.AutoComplete("lysak");

            Assert.IsNotNull(result);
            Assert.AreEqual("Lysaker #", result.First().Name);
        }
    }
}