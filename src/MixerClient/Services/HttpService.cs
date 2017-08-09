using MixerClient.Http;
using Newtonsoft.Json;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MixerClient.Services
{
    public class HttpService
    {
        private readonly MixerHttpClient _http;
        private readonly string _basePath;

        public HttpService(MixerAPI mixer, string path)
        {
            this._http = mixer.Http;
            this._basePath = path;
        }

        public async Task<T> GetAsync<T>(string queryPath, string queryString = null)
        {
            var query = _basePath;
            if (queryPath != null)
            {
                query += $"/{queryPath}";
            }
            
            var httpResponse = await _http.Http.GetAsync($"{query}{queryString}");
            httpResponse.EnsureSuccessStatusCode();
            var response = await httpResponse.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(response);
        }
        
        protected string ToQueryString(Dictionary<string, object> dic)
        {
            var array = dic.Select(option =>
                $"{System.Net.WebUtility.UrlEncode(option.Key)}={System.Net.WebUtility.UrlEncode(option.Value?.ToString())}")
                .ToArray();
            return "?" + string.Join("&", array);
        }
    }
}