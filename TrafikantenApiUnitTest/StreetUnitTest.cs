using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using System.Linq;
using System.Threading.Tasks;
using TrafikantenApi.Service.ApiClient;

namespace TrafikantenApiUnitTest
{
    [TestClass]
    public class StreetUnitTest
    {
        public async Task TestGetStreets()
        {
            var result = await Street.GetStreets("skøyen");

            Assert.IsNotNull(result);
            Assert.AreEqual("Skøyenvegen", result.First().Name);
        }
    }
}
