using System;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Threading.Tasks;

namespace ForecastIO
{
    public sealed class Api
    {
        private const string ApiAddress = "https://api.forecast.io/forecast";

        public Api(string key)
        {
            this._key = key;
        }

        public async Task<Forecast> GetForecastAsync(string latitude, string longitude)
        {
            var url = string.Format("{0}/{1}/{2},{3}", Api.ApiAddress, this._key, latitude, longitude);
            return await GetJsonAsync<Forecast>(url);
        }

        public async Task<Forecast> GetForecastAsync(string latitude, string longitude, DateTime time)
        {
            var epoch = (int)(time.ToUniversalTime() - new DateTime(1970, 1, 1)).TotalSeconds;
            var url = string.Format("{0}/{1}/{2},{3},{4}", Api.ApiAddress, this._key, latitude, longitude, epoch);
            return await GetJsonAsync<Forecast>(url);
        }

        private static async Task<T> GetJsonAsync<T>(string requestUri)
        {
            using (var client = new HttpClient())
            {
                using (var stream = await client.GetStreamAsync(requestUri))
                {
                    DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(T));
                    return (T)serializer.ReadObject(stream);
                }
            }
        }

        private string _key;
    }
}
