using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TrafikantenApi.Service.ApiClient
{
    public class Place
    {
        /// <summary>
        /// Searches for places
        /// </summary>
        /// <param name="name">Name of a place</param>
        /// <returns></returns>
        public static async Task<IList<Models.Place>> FindMatches(String name)
        {
            return await HttpWebClient.GetDataAsync<IList<Models.Place>>(Paths.Place.FindMatches, name);
        }

        /// <summary>
        /// Searches for places but limits the search to specific counties
        /// </summary>
        /// <param name="name">Name of a place</param>
        /// <param name="counties">List of counties to include in search</param>
        /// <returns></returns>
        public static async Task<IList<Models.Place>> FindMatchesByCounties(String name, params String[] counties)
        { 
            var query = String.Format("{0}?counties={1}", name, String.Join(",", counties));

            return await HttpWebClient.GetDataAsync<IList<Models.Place>>(Paths.Place.FindMatchesByCounties, query);
        }

        /// <summary>
        /// Searches for places but limits the search to specific counties
        /// </summary>
        /// <param name="name">Name of a place</param>
        /// <param name="counties">List of counties to include in search</param>
        /// <returns></returns>
        public static async Task<IList<Models.Place>> FindPlacesByCounties(String name, params String[] counties)
        {
            var query = String.Format("{0}?counties={1}", name, String.Join(",", counties));

            return await HttpWebClient.GetDataAsync<IList<Models.Place>>(Paths.Place.FindPlacesByCounties, query);
        }

        /// <summary>
        /// Base method for finding places with a specific type
        /// </summary>
        /// <typeparam name="T">Specify what type/class it should return</typeparam>
        /// <param name="name">Name of a place</param>
        /// <param name="type">None, Stop, Street or Area</param>
        /// <returns></returns>
        private static async Task<T> FindMatchesOfType<T>(String name, String type)
        {
            var query = String.Format("{0}?placeType={1}", name, type);

            return await HttpWebClient.GetDataAsync<T>(Paths.Place.FindMatchesOfType, query);
        }

        /// <summary>
        /// Finds places that are stops
        /// </summary>
        /// <param name="name">Name of a place</param>
        /// <returns></returns>
        public static async Task<IList<Models.Stop>> FindMatchesOfStop(String name)
        {
            return await FindMatchesOfType<IList<Models.Stop>>(name, "Stop");
        }

        /// <summary>
        /// Finds places that are streets
        /// </summary>
        /// <param name="name">Name of a place</param>
        /// <returns></returns>
        public static async Task<IList<Models.Street>> FindMatchesOfStreet(String name)
        {
            return await FindMatchesOfType<IList<Models.Street>>(name, "Street");
        }

        /// <summary>
        /// Finds places that are areas
        /// </summary>
        /// <param name="name">Name of a place</param>
        /// <returns></returns>
        public static async Task<IList<Models.Place>> FindMatchesOfArea(String name)
        {
            return await FindMatchesOfType<IList<Models.Place>>(name, "Area");
        }

        /// <summary>
        /// Returns a Place-object based on a place ID
        /// </summary>
        /// <param name="id">ID of place</param>
        /// <param name="name">Name of a place to help the search</param>
        /// <returns></returns>
        public static async Task<Models.Place> FindPlaceBasedOnPlaceId(long id, String name)
        {
            var query = String.Format("{0}?search={1}", id, name);

            return await HttpWebClient.GetDataAsync<Models.Place>(Paths.Place.FindPlaceBasedOnPlaceId, query);
        }

        /// <summary>
        /// Returns all stops contained in a place
        /// </summary>
        /// <param name="id">ID of place</param>
        /// <returns></returns>
        public static async Task<IList<Models.Stop>> GetStopsByPlaceId(long id)
        {
            return await HttpWebClient.GetDataAsync<IList<Models.Stop>>(Paths.Place.GetStopsByPlaceId, id);
        }

        /// <summary>
        /// Returns all stops closest to given coordinates
        /// </summary>
        /// <param name="x">Location as X-coordinate</param>
        /// <param name="y">Location as Y-coordinate</param>
        /// <param name="proposals">Number of stops to return</param>
        /// <returns></returns>
        public static async Task<IList<Models.Stop>> GetClosestStopsByCoordinates(long x, long y, int proposals)
        {
            var query = String.Format("?coordinates=(X={0},Y={1})&proposals={2}", x, y, proposals);

            return await HttpWebClient.GetDataAsync<IList<Models.Stop>>(Paths.Place.GetClosestStopsByCoordinates, query);
        }

        /// <summary>
        /// Returns all stops closest to given coordinates and walking distance
        /// </summary>
        /// <param name="x">Location as X-coordinate</param>
        /// <param name="y">Location as Y-coordinate</param>
        /// <param name="proposals">Number of stops to return</param>
        /// <param name="walkingDistance">Specify maximum walking distance in meters</param>
        /// <returns></returns>
        public static async Task<IList<Models.Stop>> GetClosestStopsAdvancedByCoordinates(long x, long y, int proposals, int walkingDistance)
        {
            var query = String.Format("?coordinates=(X={0}, Y={1})&proposals={2}&walkingDistance={3}", x, y, proposals, walkingDistance);

            return await HttpWebClient.GetDataAsync<IList<Models.Stop>>(Paths.Place.GetClosestStopsAdvancedByCoordinates, query);
        }

        /// <summary>
        /// Returns all lines (train, bus, tram etc) passing a place
        /// </summary>
        /// <param name="id">ID of place</param>
        /// <returns></returns>
        public static async Task<IList<Models.Line>> GetLines(long id)
        {
            return await HttpWebClient.GetDataAsync<IList<Models.Line>>(Paths.Place.GetLines, id);
        }

        /// <summary>
        /// Returns a list of places based on query
        /// </summary>
        /// <param name="name">Name of a place</param>
        /// <returns></returns>
        public static async Task<IList<Models.Place>> AutoComplete(String name)
        {
            return await HttpWebClient.GetDataAsync<IList<Models.Place>>(Paths.Place.Autocomplete, name);
        }

        /// <summary>
        /// Returns a list of places based on name and type
        /// </summary>
        /// <param name="name">Name of a place</param>
        /// <param name="type">Specify a type: Map, Realtime, Stop, BetweenPlaces</param>
        /// <returns></returns>
        private static async Task<IList<Models.Place>> AutoComplete(String name, String type)
        {
            var query = String.Format("{0}?autocompleteType={1}", name, type);

            return await HttpWebClient.GetDataAsync<IList<Models.Place>>(Paths.Place.Autocomplete, query);
        }

        /// <summary>
        /// Returns a list of places based on name and type
        /// </summary>
        /// <param name="name">Name of a place</param>
        /// <returns></returns>
        public static async Task<IList<Models.Place>> AutoCompleteByMap(String name)
        {
            return await AutoComplete(name, "Kart");
        }

        /// <summary>
        /// Returns a list of places based on name and type
        /// </summary>
        /// <param name="name">Name of a place</param>
        /// <returns></returns>
        public static async Task<IList<Models.Place>> AutoCompleteByRealtime(String name)
        {
            return await AutoComplete(name, "Sanntid");
        }

        /// <summary>
        /// Returns a list of places based on name and type
        /// </summary>
        /// <param name="name">Name of a place</param>
        /// <returns></returns>
        public static async Task<IList<Models.Place>> AutoCompleteByStop(String name)
        {
            return await AutoComplete(name, "Stoppested");
        }

        /// <summary>
        /// Returns a list of places based on name and type
        /// </summary>
        /// <param name="name">Name of a place</param>
        /// <returns></returns>
        public static async Task<IList<Models.Place>> AutoCompleteByBetweenPlaces(String name)
        {
            return await AutoComplete(name, "MellomSteder");
        }





    }
}
