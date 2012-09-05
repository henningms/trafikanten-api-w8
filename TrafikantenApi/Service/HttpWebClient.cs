using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TrafikantenApi.Helpers;

namespace TrafikantenApi.Service
{
    public class HttpWebClient
    {
        public static async Task<T> GetDataAsync<T>(String path, params object[] pathArgs)
        {
            var url = String.Format(path, pathArgs);

            return await GetDataAsync<T>(new Uri(url));
        }

        public static async Task<T> GetDataAsync<T>(Uri uri)
        {
            var content = await new HttpClient().GetStringAsync(uri);

            return content != null ? JsonHelper.Deserialize<T>(content) : default(T);
        }
    }
}
