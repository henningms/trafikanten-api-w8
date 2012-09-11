using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TrafikantenApi.Service.ApiClient
{
    public class Street
    {
        /// <summary>
        /// Gets all streets starting/containing/ends in given name
        /// </summary>
        /// <param name="name">Name of a street</param>
        /// <returns></returns>
        public static async Task<IList<Models.Street>> GetStreets(String name)
        {
            return await HttpWebClient.GetDataAsync<IList<Models.Street>>(Paths.Street.GetStreets, name);
        }
    }
}
