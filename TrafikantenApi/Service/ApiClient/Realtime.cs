using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TrafikantenApi.Service.ApiClient
{
    public class Realtime
    {
        /// <summary>
        /// Searches for places with given name
        /// </summary>
        /// <param name="name">Name of a place</param>
        /// <returns></returns>
        public static async Task<IList<Models.Place>> FindMatchesAsync(String name)
        {
            return await HttpWebClient.GetDataAsync<IList<Models.Place>>(Paths.Realtime.FindMatches, name);
        }

        /// <summary>
        /// Gets realtime data from provided station id
        /// </summary>
        /// <param name="stationId">ID for a station</param>
        /// <returns></returns>
        public static async Task<IList<Models.Station>> GetRealTimeDataAsync(String stationId)
        {
            return await HttpWebClient.GetDataAsync<IList<Models.Station>>(Paths.Realtime.GetRealTimeData, stationId);
        }

        /// <summary>
        /// Checks whether a name is a unique place or not
        /// </summary>
        /// <param name="name">Name of a place</param>
        /// <returns></returns>
        public static async Task<Boolean> IsUniquePlace(String name)
        {
            return await HttpWebClient.GetDataAsync<Boolean>(Paths.Realtime.IsUniquePlace, name);
        }

        /// <summary>
        /// Checks whether a name is a valid place or not
        /// </summary>
        /// <param name="name">Name of a place</param>
        /// <returns></returns>
        public static async Task<Boolean> IsValidPlace(String name)
        {
            return await HttpWebClient.GetDataAsync<Boolean>(Paths.Realtime.IsValidPlace, name);
        }
    }
}