using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafikantenApi.Service.ApiClient
{
    public class Travel
    {
        /// <summary>
        /// Gets all travel opportunities from one place to another after a specific date
        /// </summary>
        /// <param name="time">Time in format: ddMMyyyyHHmm</param>
        /// <param name="fromId">ID of place</param>
        /// <param name="toId">ID of place</param>
        /// <returns></returns>
        public static async Task<IList<Models.Travel>> GetTravelsAfter(String time, long fromId, long toId)
        {
            var query = String.Format("time={0}&from={1}&to={2}", time, fromId, toId);

            return await HttpWebClient.GetDataAsync<IList<Models.Travel>>(Paths.Travel.GetTravelsAfter, query);
        }

        /// <summary>
        /// Gets all travel opportunities from one place to another after a specific date
        /// </summary>
        /// <param name="time">Time as DateTime object</param>
        /// <param name="fromId">ID of place</param>
        /// <param name="toId">ID of place</param>
        /// <returns></returns>
        public static async Task<IList<Models.Travel>> GetTravelsAfter(DateTime time, long fromId, long toId)
        {
            return await GetTravelsAfter(Helpers.DateHelper.DateTimeToTimeString(time), fromId, toId);
        }

        public static async Task<IList<Models.Travel>> GetTravelsAfterNow(long fromId, long toId)
        {
            return await GetTravelsAfter(Helpers.DateHelper.DateTimeToTimeString(DateTime.Now),
                fromId, toId);
        }

        /// <summary>
        /// Gets all travel opportunities from one stop to another after a specific date
        /// </summary>
        /// <param name="time">Time in format: ddMMyyyyHHmm</param>
        /// <param name="fromStopId">ID of stop</param>
        /// <param name="toStopId">ID of stop</param>
        /// <returns></returns>
        public static async Task<IList<Models.Travel>> GetTravelsAfterByStops(String time, long fromStopId, long toStopId)
        {
            var query = String.Format("time={0}&fromstops={1}&tostops={2}", time, fromStopId, toStopId);

            return await HttpWebClient.GetDataAsync<IList<Models.Travel>>(Paths.Travel.GetTravelsAfterByStops, query);
        }

        /// <summary>
        /// Gets all travel opportunities from one stop to another after a specific date
        /// </summary>
        /// <param name="time">Tme as Datetime object</param>
        /// <param name="fromStopId">ID of stop</param>
        /// <param name="toStopId">ID of stop</param>
        /// <returns></returns>
        public static async Task<IList<Models.Travel>> GetTravelsAfterByStops(DateTime time, long fromStopId, long toStopId)
        {
            return await GetTravelsAfterByStops(Helpers.DateHelper.DateTimeToTimeString(time), fromStopId, toStopId);
        }

        /// <summary>
        /// Gets all travel opportunities from a place to another before a given date
        /// </summary>
        /// <param name="time">Time in format ddMMyyyyHHmm</param>
        /// <param name="fromId">ID of place</param>
        /// <param name="toId">ID of place</param>
        /// <returns></returns>
        public static async Task<IList<Models.Travel>> GetTravelsBefore(String time, long fromId, long toId)
        {
            var query = String.Format("time={0}&from={1}&to={2}", time, fromId, toId);

            return await HttpWebClient.GetDataAsync<IList<Models.Travel>>(Paths.Travel.GetTravelsBefore, query);
        }

        /// <summary>
        /// Gets all travel opportunities from a place to another before a given date
        /// </summary>
        /// <param name="time">Time as DateTime-object</param>
        /// <param name="fromId">ID of place</param>
        /// <param name="toId">ID of place</param>
        /// <returns></returns>
        public static async Task<IList<Models.Travel>> GetTravelsBefore(DateTime time, long fromId, long toId)
        {
            return await GetTravelsBefore(Helpers.DateHelper.DateTimeToTimeString(time), fromId, toId);
        }

        /// <summary>
        /// Gets all travel opportunities from a stop to another before a given date
        /// </summary>
        /// <param name="time">Time in format: ddMMyyyyHHmm</param>
        /// <param name="fromStopId">ID of stop</param>
        /// <param name="toStopId">ID of stop</param>
        /// <returns></returns>
        public static async Task<IList<Models.Travel>> GetTravelsBeforeByStops(String time, long fromStopId, long toStopId)
        {
            var query = String.Format("time={0}&fromstops={1}&tostops={2}", time, fromStopId, toStopId);

            return await HttpWebClient.GetDataAsync<IList<Models.Travel>>(Paths.Travel.GetTravelsBeforeByStops, query);
        }

        /// <summary>
        /// Gets all travel opportunities from a stop to another before a given date
        /// </summary>
        /// <param name="time">Time as DateTime-object</param>
        /// <param name="fromStopId">ID of stop</param>
        /// <param name="toStopId">ID of stop</param>
        /// <returns></returns>
        public static async Task<IList<Models.Travel>> GetTravelsBeforeByStops(DateTime time, long fromStopId, long toStopId)
        {
            return await GetTravelsBeforeByStops(Helpers.DateHelper.DateTimeToTimeString(time), fromStopId, toStopId);
        }

        /// <summary>
        /// Gets all travel opportunities from a stop to another with specific parameters
        /// </summary>
        /// <param name="time">Time in format: ddMMyyyyHHmm</param>
        /// <param name="fromStopId">ID of stop</param>
        /// <param name="toStopId">ID of stop</param>
        /// <param name="changeMargin">Limit the times to change transportation to get there</param>
        /// <param name="changePunish"></param>
        /// <param name="walkingFactor"></param>
        /// <param name="isAfter">Specify if search is after or before given date</param>
        /// <param name="proposals">Specify a number of results to get back</param>
        /// <param name="transportTypes">Types of transportation to limit travel: Bus, Tram, Train, etc</param>
        /// <returns></returns>
        public static async Task<IList<Models.Travel>> GetTravelsAdvanced(String time, long fromStopId, long toStopId,
            int changeMargin, int changePunish, int walkingFactor, bool isAfter, int proposals, params String[] transportTypes)
        {
            var transport = String.Join(",", transportTypes);

            var query = 
                String.Format("time={0}&fromstops={1}&tostops={2}&changeMargin={3}&changePunish={4}&walkingFactor={5}&" + 
                "isAfter={6}&proposals={7}&transporttypes={8}", time, fromStopId, toStopId, changeMargin, changePunish,
                walkingFactor, isAfter, proposals, transport);

            return await HttpWebClient.GetDataAsync<IList<Models.Travel>>(Paths.Travel.GetTravelsAdvanced, query);
        }

        /// <summary>
        /// Gets all travel opportunities from a stop to another with specific parameters
        /// </summary>
        /// <param name="time">Time as DateTime-object</param>
        /// <param name="fromStopId">ID of stop</param>
        /// <param name="toStopId">ID of stop</param>
        /// <param name="changeMargin">Limit the times to change transportation to get there</param>
        /// <param name="changePunish"></param>
        /// <param name="walkingFactor"></param>
        /// <param name="isAfter">Specify if search is after or before given date</param>
        /// <param name="proposals">Specify a number of results to get back</param>
        /// <param name="transportTypes">Types of transportation to limit travel: Bus, Tram, Train, etc</param>
        /// <returns></returns>
        public static async Task<IList<Models.Travel>> GetTravelsAdvanced(DateTime time, long fromStopId, long toStopId,
            int changeMargin, int changePunish, int walkingFactor, bool isAfter, int proposals, params String[] transportTypes)
        {
            return await GetTravelsAdvanced(Helpers.DateHelper.DateTimeToTimeString(time), fromStopId, toStopId, changeMargin,
                changePunish, walkingFactor, isAfter, proposals, transportTypes);
        }

        /// <summary>
        /// Gets all travel opportunities from one coordinate to another with specific parameters
        /// </summary>
        /// <param name="time">Time in format: ddMMyyyyHHmm</param>
        /// <param name="fromX">From X-coordinate</param>
        /// <param name="fromY">From Y-coordinate</param>
        /// <param name="toX">To X-coordinate</param>
        /// <param name="toY">To Y-coordinate</param>
        /// <param name="changeMargin">Specify how many times we can change transportation</param>
        /// <param name="changePunish"></param>
        /// <param name="walkingFactor"></param>
        /// <param name="isAfter">Specify if search is after or before given date</param>
        /// <param name="proposals">Limit results to given number</param>
        /// <param name="transportTypes">Types of transportation we want</param>
        /// <returns></returns>
        public static async Task<IList<Models.Travel>> GetTravelsAdvancedByCoordinates(String time, long fromX, long fromY,
            long toX, long toY, int changeMargin, int changePunish, int walkingFactor, bool isAfter, int proposals,
            params String[] transportTypes)
        {
            var transport = String.Join(",", transportTypes);

            var query =
                String.Format("time={0}&fromcoordinates=(X={1},Y={2})&tocoordinates=(X={3},Y={4})&changeMargin={5}&changePunish={6}&" +
                "walkingFactor={7}&isAfter={8}&proposals={9}&transporttypes={10}", time, fromX, fromY, toX, toY, changeMargin, changePunish,
                walkingFactor, isAfter, proposals, transport);

            return await HttpWebClient.GetDataAsync<IList<Models.Travel>>(Paths.Travel.GetTravelsAdvancedByCoordinates, query);
        }

        /// <summary>
        /// Gets all travel opportunities from one coordinate to another with specific parameters
        /// </summary>
        /// <param name="time">Time as DateTime-object</param>
        /// <param name="fromX">From X-coordinate</param>
        /// <param name="fromY">From Y-coordinate</param>
        /// <param name="toX">To X-coordinate</param>
        /// <param name="toY">To Y-coordinate</param>
        /// <param name="changeMargin">Specify how many times we can change transportation</param>
        /// <param name="changePunish"></param>
        /// <param name="walkingFactor"></param>
        /// <param name="isAfter">Specify if search is after or before given date</param>
        /// <param name="proposals">Limit results to given number</param>
        /// <param name="transportTypes">Types of transportation we want</param>
        /// <returns></returns>
        public static async Task<IList<Models.Travel>> GetTravelsAdvancedByCoordinates(DateTime time, long fromX, long fromY,
            long toX, long toY, int changeMargin, int changePunish, int walkingFactor, bool isAfter, int proposals,
            params String[] transportTypes)
        {
            return await GetTravelsAdvancedByCoordinates(Helpers.DateHelper.DateTimeToTimeString(time), fromX, fromY, toX, toY, changeMargin,
                changePunish, walkingFactor, isAfter, proposals, transportTypes);
        }

        
    }
}
