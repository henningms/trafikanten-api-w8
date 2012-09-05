using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafikantenApi.Service.ApiClient
{
    public class TravelStage
    {
        public static async Task<IList<Models.Travelstage>> GetArrivals(long placeId, String time)
        {
            var query = String.Format("{0}?time={1}", placeId, time);

            return await HttpWebClient.GetDataAsync<IList<Models.Travelstage>>(Paths.Travelstage.GetArrivals, query);
        }

        public static async Task<IList<Models.Travelstage>> GetArrivals(long placeId, DateTime time)
        {
            return await GetArrivals(placeId, Helpers.DateHelper.DateTimeToTimeString(time));
        }

        public static async Task<IList<Models.Travelstage>> GetArrivalsAdvanced(long placeId, String time,
            String[] lines, params String[] transportTypes)
        { 
            var joinedLines = String.Join(",", lines);
            var transport = String.Join(",", transportTypes);

            var query = String.Format("{0}?time={1}&lines={2}&transporttypes={3}", placeId, time,
                joinedLines, transport);

            return await HttpWebClient.GetDataAsync<IList<Models.Travelstage>>(Paths.Travelstage.GetArrivalsAdvanced, query);
        }

        public static async Task<IList<Models.Travelstage>> GetArrivalsAdvanced(long placeId, DateTime time,
           String[] lines, params String[] transportTypes)
        {
            return await GetArrivalsAdvanced(placeId, Helpers.DateHelper.DateTimeToTimeString(time), lines, transportTypes);
        }

        public static async Task<IList<Models.Travelstage>> GetDepartures(long placeId, String time)
        {
            var query = String.Format("{0}?time={1}", placeId, time);

            return await HttpWebClient.GetDataAsync<IList<Models.Travelstage>>(Paths.Travelstage.GetDepartures, query);
        }

        public static async Task<IList<Models.Travelstage>> GetDepartures(long placeId, DateTime time)
        {
            return await GetDepartures(placeId, Helpers.DateHelper.DateTimeToTimeString(time));
        }

        public static async Task<IList<Models.Travelstage>> GetDeparturesAdvanced(long placeId, String time,
            String[] lines, params String[] transportTypes)
        {
            var joinedLines = String.Join(",", lines);
            var transport = String.Join(",", transportTypes);

            var query = String.Format("{0}?time={1}&lines={2}&transporttypes={3}", placeId, time,
                joinedLines, transport);

            return await HttpWebClient.GetDataAsync<IList<Models.Travelstage>>(Paths.Travelstage.GetDeparturesAdvanced, query);
        }

        public static async Task<IList<Models.Travelstage>> GetDeparturesAdvanced(long placeId, DateTime time,
           String[] lines, params String[] transportTypes)
        {
            return await GetDeparturesAdvanced(placeId, Helpers.DateHelper.DateTimeToTimeString(time), lines, transportTypes);
        }

    }
}
