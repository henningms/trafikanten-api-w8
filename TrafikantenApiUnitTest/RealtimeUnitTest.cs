using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafikantenApiUnitTest
{
    [TestClass]
    public class RealtimeUnitTest
    {
        [TestMethod]
        public async Task TestFindMatches()
        {
            var result = await TrafikantenApi.Service.ApiClient.Realtime.FindMatchesAsync("skøyen");

            Assert.IsNotNull(result);
            Assert.AreEqual("Skøyen [tog]", result.First().Name);
        }

        [TestMethod]
        public async Task TestGetRealTimeData()
        {
            var result = await TrafikantenApi.Service.ApiClient.Realtime.GetRealTimeDataAsync("3011320");

            Assert.IsNotNull(result);
            Assert.AreEqual(true, result.Any());
        }

        [TestMethod]
        public async Task TestIsUniquePlace()
        {
            var result = await TrafikantenApi.Service.ApiClient.Realtime.IsUniquePlace("Skøyen [tog]");

            Assert.IsNotNull(result);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public async Task TestIsValidPlace()
        {
            var result = await TrafikantenApi.Service.ApiClient.Realtime.IsValidPlace("skøyen");

            Assert.IsNotNull(result);
            Assert.AreEqual(true, result);
        }
    }
}
