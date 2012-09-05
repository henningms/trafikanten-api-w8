using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafikantenApi.Service.ApiClient
{
    public class Trip
    {
        public static async Task<Models.Trip> GetTrip(long tripId, String time)
        {
            var query = String.Format("{0}?time={1}", tripId, time);

            return await HttpWebClient.GetDataAsync<Models.Trip>(Paths.Trip.GetTrip, query);
        }

        public static async Task<Models.Trip> GetTrip(long tripId, DateTime time)
        {
            return await GetTrip(tripId, Helpers.DateHelper.DateTimeToTimeString(time));
        }
    }
}
